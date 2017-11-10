using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MyZoo.DAL;
using MyZoo.Models;

namespace MyZoo.UI
{
    public partial class Booking : Form
    {
        private DataAccess _dataAccess;

        public Booking()
        {
            InitializeComponent();

            _dataAccess = new DataAccess();

            vetrinaryDataGridView.DataSource = _dataAccess.GetVetrinariesInfo();

            LoadAnimals();

            //SetBookingHistroy(GetIdOfSelectedRow(animalsDataGridView));

            RefreshTables();
        }

        public void LoadAnimals()
        {
            //get all animals and select id and species
            List<SimpleAnimal> animals = _dataAccess.GetAnimalInfos("", "", "")
                .Select(a => new SimpleAnimal {Id = a.Id, Species = a.Species}).ToList();

            animalsDataGridView.DataSource = animals;
        }

        public void SetBookingHistroy(int animalId)
        {
            if (animalId > 0)
            {
                bookingHistoryDataGridView.DataSource = _dataAccess.GetBookingsForAnimal(animalId)
                    .Select(a => new BookedTimes
                    {
                        AnimalId = a.AnimalId,
                        BookingId = a.Id,
                        StartDate = a.StartDate,
                        EndDate = a.EndDate,
                        VeterinaryId = a.VeterinaryId
                    }).ToList();
            }
        }

        private void searchTimesBTN_Click(object sender, EventArgs e)
        {
            LoadAvailableTimes();
        }

        private void LoadAvailableTimes()
        {
            List<BookingInfo> bookings = new List<BookingInfo>();

            int veterinaryId = GetIdOfSelectedRow(vetrinaryDataGridView);

            int animalId = GetIdOfSelectedRow(animalsDataGridView);

            if (veterinaryId <= 0 || animalId <= 0)
                return;

            //Get Date from picker
            DateTime date = dateTimePicker1.Value;

            //if date is in the future and on working day
            if (date >= DateTime.Now && date.DayOfWeek != DayOfWeek.Sunday)
            {
                //Load all possible times for the schedueele
                for (int startHour = 9; startHour < 15; startHour++)
                {
                    DateTime startDate = date + new TimeSpan(startHour, 00, 00);
                    DateTime endDate = date + new TimeSpan(startHour, 59, 00);

                    BookingInfo info = new BookingInfo
                    {
                        VetId = veterinaryId,
                        Start = startDate,
                        End = endDate,
                        AnimalId = animalId
                    };

                    bookings.Add(info);
                }
            }

            //Get all bookings with veterinary on specific day
            List<DataContext.Booking> vetBookings = _dataAccess.GetBookingsForVeterinary(veterinaryId)
                .Where(v => v.StartDate.Date == date.Date)
                .ToList();

            //Remove times where the vetrinary is busy
            foreach (var vBook in vetBookings)
            {
                for (int i = bookings.Count - 1; i >= 0; i--)
                {
                    if (IsBetweenDate(vBook.StartDate, bookings[i].Start, bookings[i].End) ||
                        IsBetweenDate(vBook.EndDate, bookings[i].Start, bookings[i].End))
                    {
                        bookings.RemoveAt(i);
                    }
                }
            }

            //Get all bookings for animal
            var animalBookings = _dataAccess.GetBookingsForAnimal(animalId)
                .Where(b => b.StartDate.Date == date.Date)
                .ToList();

            //Remove times where the animal is busy
            foreach (var aBook in animalBookings)
            {
                for (int i = bookings.Count - 1; i >= 0; i--)
                {
                    if (IsBetweenDate(aBook.StartDate, bookings[i].Start, bookings[i].End) ||
                        IsBetweenDate(aBook.EndDate, bookings[i].Start, bookings[i].End))
                    {
                        bookings.RemoveAt(i);
                    }
                }
            }

            freeTimesDataGridView.DataSource = bookings;
        }

        public bool IsBetweenDate(DateTime date, DateTime startDate, DateTime endDate)
        {
            return date >= startDate && date <= endDate;
        }

        private int GetIdOfSelectedRow(DataGridView dw)
        {
            int row = GetIndexOfSelectedRowOrCell(dw);

            if (row >= 0)
            {
                return (int)dw[0, row].Value;
            }

            return -1;
        }

        private int GetIndexOfSelectedRowOrCell(DataGridView dw)
        {
            for (int i = 0; i < dw.RowCount; i++)
            {
                //if row is selected
                if (dw.Rows[i].Selected)
                {
                    return i;
                }

                //if cell is selected
                for (int x = 0; x < dw.ColumnCount; x++)
                {
                    if (dw[x, i].Selected)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        private void animalsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshTables();
        }

        private void vetrinaryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadAvailableTimes();
        }

        private void bookTimeBTN_Click(object sender, EventArgs e)
        {
            int selectedRow = GetIndexOfSelectedRowOrCell(freeTimesDataGridView);
            
            if(selectedRow < 0)
                return;

            int vetId = (int)freeTimesDataGridView[0, selectedRow].Value;
            int animalId = (int) freeTimesDataGridView[3, selectedRow].Value;

            DateTime startDate = (DateTime) freeTimesDataGridView[1, selectedRow].Value;
            DateTime endDate = (DateTime) freeTimesDataGridView[1, selectedRow].Value;

            _dataAccess.AddBooking(animalId, vetId ,startDate, endDate);

            RefreshTables();
        }

        private void RefreshTables()
        {
            //remove info message
            deleteInfoLabel.Text = "";

            //Load available booking times
            LoadAvailableTimes();

            //Load history of animal booking
            SetBookingHistroy(GetIdOfSelectedRow(animalsDataGridView));
        }

        private void deleteBookingBTN_Click(object sender, EventArgs e)
        {
            int bookingId = GetIdOfSelectedRow(bookingHistoryDataGridView);

            //if bookingId is valid 
            if (bookingId > 0)
            {
                //and if starttime is after current time
                if ((DateTime) bookingHistoryDataGridView[3,
                        GetIndexOfSelectedRowOrCell(bookingHistoryDataGridView)
                    ].Value > DateTime.Now)
                {
                    //then remove booking
                    _dataAccess.DeleteBooking(bookingId);

                    RefreshTables();

                    deleteInfoLabel.Text = "Booking successfully removed";
                }
                else
                {
                    deleteInfoLabel.Text = "You cannot delete booking \nafter it started.";
                }

            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshTables();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookingId = GetIdOfSelectedRow(bookingHistoryDataGridView);

            //if bookingId is valid 
            if (bookingId > 0)
            {
                int animalId = (int)bookingHistoryDataGridView
                    [1,GetIndexOfSelectedRowOrCell(bookingHistoryDataGridView)]
                    .Value;
                Diagnosis diagnosisForm = new Diagnosis(bookingId, animalId);
                diagnosisForm.Show();
            }
        }
    }
}

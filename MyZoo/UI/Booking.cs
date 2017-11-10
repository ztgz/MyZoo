using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MyZoo.DAL;
using MyZoo.Extensions;
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

            //Load All veterinaries
            vetrinaryDataGridView.DataSource = _dataAccess.GetVetrinariesInfo();

            LoadAnimals();

        }

        /*------------------------- Load Tables ------------------------------*/
        public void LoadAnimals()
        {
            //Get List of AnimalModel from list of Animals
            List<SimpleAnimal> animals = _dataAccess.GetAnimalInfos("", "", "")
                .Select(a => new SimpleAnimal {Id = a.Id, Species = a.Species}).ToList();

            animalsDataGridView.DataSource = animals;
        }

        private void LoadAvailableTimes()
        {
            //List to store bookings to fill the form
            List<BookingInfo> bookings = new List<BookingInfo>();

            /*Retrive data from tables */
            int veterinaryId = GetIdOfSelectedRow(vetrinaryDataGridView);

            int animalId = GetIdOfSelectedRow(animalsDataGridView);

            DateTime date = dateTimePicker1.Value;
            
            // If something went wrong
            if (veterinaryId <= 0 || animalId <= 0)
                return;

            //if date is in the future and on working day, fill list with all possible times
            if (date.Date >= DateTime.Now.Date && date.DayOfWeek != DayOfWeek.Sunday)
            {
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

            //Get all bookings with the selected veterinary on the specific day
            List<DataContext.Booking> vetBookings = _dataAccess.GetBookingsForVeterinary(veterinaryId)
                .Where(v => v.StartDate.Date == date.Date)
                .ToList();

            //Remove the times when the vetrinary is busy
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

            //Get all bookings for the animal
            var animalBookings = _dataAccess.GetBookingsForAnimal(animalId)
                .Where(b => b.StartDate.Date == date.Date)
                .ToList();

            //Remove times where the animal allready have an appointment
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

            //Fill datagridview with all possible times
            freeTimesDataGridView.DataSource = bookings;
        }

        public void LoadBookingHistroy(int animalId)
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

        private void RefreshTables()
        {
            //Remove info message
            deleteInfoLabel.Text = "";

            //Load available booking times
            LoadAvailableTimes();

            //Load history of animal booking
            LoadBookingHistroy(GetIdOfSelectedRow(animalsDataGridView));
        }


        /*------------------------- Button clicks that reload tables------------------------------*/
        private void animalsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshTables();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshTables();
        }

        private void searchTimesBTN_Click(object sender, EventArgs e)
        {
            LoadAvailableTimes();
        }

        private void vetrinaryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadAvailableTimes();
        }


        /*------------------------- Button clicks that changes record or open forms------------------------------*/
        private void bookTimeBTN_Click(object sender, EventArgs e)
        {
            int selectedRow = HelperMethod.GetSelectedRowIndex(freeTimesDataGridView);
            
            if(selectedRow < 0)
                return;

            /*Load the data that will be in the booking*/
            int vetId = (int)freeTimesDataGridView[0, selectedRow].Value;
            int animalId = (int) freeTimesDataGridView[3, selectedRow].Value;

            DateTime startDate = (DateTime) freeTimesDataGridView[1, selectedRow].Value;
            DateTime endDate = (DateTime) freeTimesDataGridView[1, selectedRow].Value;

            //Add booking record
            _dataAccess.AddBooking(animalId, vetId ,startDate, endDate);

            //Reload tables
            RefreshTables();
        }

        private void deleteBookingBTN_Click(object sender, EventArgs e)
        {
            //Which booking to delet
            int bookingId = GetIdOfSelectedRow(bookingHistoryDataGridView);

            //if bookingId is valid 
            if (bookingId > 0)
            {
                //And if starttime is after current time
                if ((DateTime) bookingHistoryDataGridView[3,
                        HelperMethod.GetSelectedRowIndex(bookingHistoryDataGridView)
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

        //Open diagnosis form
        private void button1_Click(object sender, EventArgs e)
        {
            int bookingId = GetIdOfSelectedRow(bookingHistoryDataGridView);

            //If bookingId is valid 
            if (bookingId > 0)
            {
                this.Hide();

                int animalId = (int)bookingHistoryDataGridView
                    [1,HelperMethod.GetSelectedRowIndex(bookingHistoryDataGridView)].Value;

                Diagnosis diagnosisForm = new Diagnosis(bookingId, animalId, this);

                diagnosisForm.Show();
            }
        }


        /*------------------------- Helper Methods ------------------------------*/
        private bool IsBetweenDate(DateTime date, DateTime startDate, DateTime endDate)
        {
            return date >= startDate && date <= endDate;
        }

        private int GetIdOfSelectedRow(DataGridView dw)
        {
            int row = HelperMethod.GetSelectedRowIndex(dw);

            if (row >= 0)
            {
                return (int)dw[0, row].Value;
            }

            return -1;
        }

    }
}

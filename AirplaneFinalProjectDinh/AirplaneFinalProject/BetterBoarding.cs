using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**************************************************************
* Name        : Airplane Boarding
* Author      : Trong Dinh
* Created     : 3/31/2020
* Course      : CIS 152 - Data Structures
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program overall description here
*               Input:  list and describe
*               Output: list and describe
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/

namespace AirplaneFinalProject
{
    public partial class BetterBoarding : Form
    {
        const int PLANEONESIZE = 136;
        const int PLANEONEMODSIZE = 34;
        const int PLANETWOSIZE = 213;
        const int PLANETWOSPLITONE = 108;
        const int PLANETWOSPLITTWO = 105;
        const int PLANETWOMODSIZEONE = 35;
        const int PLANETWOMODSIZETWO = 38;
        string[] planeOneSeats = new string[PLANEONESIZE] {"A1", "A2", "A3", "A4", "A6", "A7", "A8", "A9", "A10", "A11", "A12", "A14", "A15", "A16", "A17", "A18", "A19", "A20", "A21", "A22", "A23", "A24", "A25", "A26",
                                                           "B6", "B7", "B8", "B9", "B10", "B11", "B12", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26",
                                                           "C1", "C2", "C3", "C4", "C6", "C7", "C8", "C9", "C10", "C11", "C12", "C14", "C15", "C16", "C17", "C18", "C19", "C20", "C21", "C22", "C23", "C24", "C25", "C26",
                                                           "D1", "D2", "D3", "D4", "D6", "D7", "D8", "D9", "D10", "D11", "D12", "D14", "D15", "D16", "D17", "D18", "D19", "D20", "D21", "D22", "D23", "D24", "D25", "D26",
                                                           "E6", "E7", "E8", "E9", "E10", "E11", "E12", "E14", "E15", "E16", "E17", "E18", "E19", "E20", "E21", "E22", "E23", "E24", "E25", "E26",
                                                           "F1", "F2", "F3", "F4", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "F14", "F15", "F16", "F17", "F18", "F19", "F20", "F21", "F22", "F23", "F24", "F25", "F26"};
        string[] steffenPerfPlaneOne = new string[PLANEONESIZE] {"F26", "F24", "F22", "F20", "F18", "F16", "F14", "F11", "F9", "F7", "F4", "F2",
                                                                 "A26", "A24", "A22", "A20", "A18", "A16", "A14", "A11", "A9", "A7", "A4", "A2",
                                                                 "F25", "F23", "F21", "F19", "F17", "F15", "F13", "F10", "F8", "F6", "F3", "F1",
                                                                 "A25", "A23", "A21", "A19", "A17", "A15", "A13", "A10", "A8", "A6", "A3", "A1",
                                                                 "E26", "E24", "E22", "E20", "E18", "E16", "E14", "E11", "E9", "E7",
                                                                 "B26", "B24", "B22", "B20", "B18", "B16", "B14", "B11", "B9", "B7",
                                                                 "E25", "E23", "E21", "E19", "E17", "E15", "E13", "E10", "E8", "E6",
                                                                 "B25", "B23", "B21", "B19", "B17", "B15", "B13", "B10", "B8", "B6",
                                                                 "D26", "D24", "D22", "D20", "D18", "D16", "D14", "D11", "D9", "D7", "D4", "D2",
                                                                 "C26", "C24", "C22", "C20", "C18", "C16", "C14", "C11", "C9", "C7", "C4", "C2",
                                                                 "D25", "D23", "D21", "D19", "D17", "D15", "D13", "D10", "D8", "D6", "D3", "D1",
                                                                 "C25", "C23", "C21", "C19", "C17", "C15", "C13", "C10", "C8", "C6", "C3", "C1"};
        string[] steffenModPlaneOne1 = new string[PLANEONEMODSIZE] {"A1", "C1", "A3", "C3", "A6", "B6", "C6", "A8", "B8", "C8", "A10", "B10", "C10", "A12", "B12", "C12", "A15", "B15",
                                                                    "C15", "A17", "B17", "C17", "A19", "B19", "C19", "A21", "B21", "C21", "A23", "B23", "C23", "A25", "B25", "C25"};
        string[] steffenModPlaneOne2 = new string[PLANEONEMODSIZE] {"D1", "F1", "D3", "F3", "D6", "E6", "F6", "D8", "E8", "F8", "D10", "E10", "F10", "D12", "E12", "F12", "D15", "E15",
                                                                    "F15", "D17", "E17", "F17", "D19", "E19", "F19", "D21", "E21", "F21", "D23", "E23", "F23", "D25", "E25", "F25"};
        string[] steffenModPlaneOne3 = new string[PLANEONEMODSIZE] {"A2", "C2", "A4", "C4", "A7", "B7", "C7", "A9", "B9", "C9", "A11", "B11", "C11", "A14", "B14", "C14", "A16", "B16",
                                                                    "C16", "A18", "B18", "C18", "A20", "B20", "C20", "A22", "B22", "C22", "A24", "B24", "C24", "A26", "B26", "C26"};
        string[] steffenModPlaneOne4 = new string[PLANEONEMODSIZE] {"D2", "F2", "D4", "F4", "D7", "E7", "F7", "D9", "E9", "F9", "D11", "E11", "F11", "D14", "E14", "F14", "D16", "E16",
                                                                    "F16", "D18", "E18", "F18", "D20", "E20", "F20", "D22", "E22", "F22", "D24", "E24", "F24", "D26", "E26", "F26"};
        string[] planeTwoSeats = new string[PLANETWOSIZE] {"A1", "A2", "A4", "A5", "A6", "A7", "A8", "A9", "A10", "A11", "A12", "A13", "A14", "A15", "A16", "A17", "A18", "A19", "A20", "A21", "A22", "A23", "A24", "A25", "A26", "A27",
                                                           "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27",
                                                           "C1", "C2", "C4", "C5", "C6", "C7", "C8", "C9", "C10", "C11", "C12", "C13", "C14", "C15", "C16", "C17", "C18", "C19", "C20", "C21",
                                                           "D1", "D2", "D5", "D6", "D7", "D8", "D9", "D10", "D11", "D12", "D13", "D14", "D15", "D16", "D17", "D18", "D19", "D20", "D21", "D22", "D23", "D24", "D25", "D26", "D27",
                                                           "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "F13", "F14", "F15", "F16", "F17", "F18", "F19", "F20", "F21", "F22", "F23", "F24", "F25", "F26", "F27",
                                                           "G1", "G2", "G5", "G6", "G7", "G8", "G9", "G10", "G11", "G12", "G13", "G14", "G15", "G16", "G17", "G18", "G19", "G20", "G21", "G22", "G23", "G24", "G25", "G26", "G27",
                                                           "F1", "F2", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "F13", "F14", "F15", "F16", "F17", "F18", "F19", "F20", "F21",
                                                           "J4", "J5", "J6", "J7", "J8", "J9", "J10", "J11", "J12", "J13", "J14", "J15", "J16", "J17", "J18", "J19", "J20", "J21", "J22", "J23", "J24", "J25", "J26", "J27",
                                                           "K1", "K2", "K4", "K5", "K6", "K7", "K8", "K9", "K10", "K11", "K12", "K13", "K14", "K15", "K16", "K17", "K18", "K19", "K20", "K21", "K22", "K23", "K24", "K25", "K26", "K27"};
        string[] steffenPerfPlaneTwoQueueOne = new string[PLANETWOSPLITONE] {"A27", "A25", "A23", "A21", "A19", "A17", "A15", "A13", "A11", "A9", "A7", "A5", "A2",
                                                                             "G27", "G25", "G23", "G21", "G19", "G17", "G15", "G13", "G11", "G9", "G7", "G5", "G1",
                                                                             "B27", "B25", "B23", "B21", "B19", "B17", "B15", "B13", "B11", "B9", "B7", "B5",
                                                                             "F27", "F25", "F23", "F21", "F19", "F17", "F15", "F13", "F11", "F9", "F7", "F5",
                                                                             "C21", "C19", "C17", "C15", "C13", "C11", "C9", "C7", "C5", "C2",
                                                                             "D27", "D25", "D23", "D21", "D19", "D17", "D15", "D13", "D11", "D9", "D7", "D5", "D1",
                                                                             "A26", "A24", "A22", "A20", "A18", "A16", "A14", "A12", "A10", "A8", "A6", "A4", "A1",
                                                                             "B26", "B24", "B22", "B20", "B18", "B16", "B14", "B12", "B10", "B8", "B6", "B4",
                                                                             "C20", "C18", "C16", "C14", "C12", "C10", "C8", "C6", "C4", "C1"};
        string[] steffenPerfPlaneTwoQueueTwo = new string[PLANETWOSPLITTWO] {"K27", "K25", "K23", "K21", "K19", "K17", "K15", "K13", "K11", "K9", "K7", "K5", "K2",
                                                                             "D26", "D24", "D22", "D20", "D18", "D16", "D14", "D12", "D10", "D8", "D6", "D2",
                                                                             "J27", "J25", "J23", "J21", "J19", "J17", "J15", "J13", "J11", "J9", "J7", "J5",
                                                                             "F26", "F24", "F22", "F20", "F18", "F16", "F14", "F12", "F10", "F8", "F6",
                                                                             "H21", "H19", "H17", "H15", "H13", "H11", "H9", "H7", "H5", "H2",
                                                                             "G26", "G24", "G22", "G20", "G18", "G16", "G14", "G12", "G10", "G8", "G6", "G2",
                                                                             "K26", "K24", "K22", "K20", "K18", "K16", "K14", "K12", "K10", "K8", "K6", "K4", "K1",
                                                                             "J26", "J24", "J22", "J20", "J18", "J16", "J14", "J12", "J10", "J8", "J6", "J4",
                                                                             "H20", "H18", "H16", "H14", "H12", "H10", "H8", "H6", "H4", "H1" };
        string[] steffenModPlaneTwo1A = new string[PLANETWOMODSIZEONE] {"A1", "C1", "A4", "B4", "C4", "A6", "B6", "C6", "A8", "B8", "C8", "A10", "B10", "C10", "A12", "B12", "C12",
                                                                        "A14", "B14", "C14", "A16", "B16", "C16", "A18", "B18", "C18", "A20", "B20", "C20", "A22", "B22", "A24", "B24", "A26", "B26"};
        string[] steffenModPlaneTwo2A = new string[PLANETWOMODSIZEONE] {"A2", "C2", "A5", "B5", "C5", "A7", "B7", "C7", "A9", "B9", "C9", "A11", "B11", "C11", "A13", "B13", "C13",
                                                                        "A15", "B15", "C15", "A17", "B17", "C17", "A19", "B19", "C19", "A21", "B21", "C21", "A23", "B23", "A25", "B25", "A27", "B27"};
        string[] steffenModPlaneTwo3A = new string[PLANETWOMODSIZETWO] {"G1", "D1", "G5", "F5", "D5", "G7", "F7", "D7", "G9", "F9", "D9", "G11", "F11", "D11",
                                                                        "G13", "F13", "D13", "G15", "F15", "D15", "G17", "F17", "D17", "G19", "F19", "D19", "G21", "F21", "D21", "G23", "F23", "D23", "G25", "F25", "D25", "G27", "F27", "D27"};
        string[] steffenModPlaneTwo1B = new string[PLANETWOMODSIZEONE] {"K1", "H1", "K4", "K4", "H4", "K6", "K6", "H6", "K8", "K8", "H8", "K10", "K10", "H10", "K12", "K12", "H12",
                                                                        "K14", "K14", "H14", "K16", "K16", "H16", "K18", "K18", "H18", "K20", "K20", "H20", "K22", "K22", "K24", "K24", "K26", "K26"};
        string[] steffenModPlaneTwo2B = new string[PLANETWOMODSIZEONE] {"K2", "H2", "K5", "J5", "H5", "K7", "J7", "H7", "K9", "J9", "H9", "K11", "J11", "H11", "K13", "J13", "H13",
                                                                        "K15", "J15", "H15", "K17", "J17", "H17", "K19", "J19", "H19", "K21", "J21", "H21", "K23", "J23", "K25", "J25", "K27", "J27"};
        string[] steffenModPlaneTwo3B = new string[PLANETWOMODSIZEONE] {"G2", "D2", "G6", "F6", "D6", "G8", "F8", "D8", "G10", "F10", "D10", "G12", "F12", "D12",
                                                                        "G14", "F14", "D14", "G16", "F16", "D16", "G18", "F18", "D18", "G20", "F20", "D20", "G22", "F22", "D22", "G24", "F24", "D24", "G26", "F26", "D26"};
        List<Passenger> passengerList = new List<Passenger>();
        Queue lineOneQueue = new Queue();
        public BetterBoarding()
        {
            InitializeComponent();
        }
        /**************************************************************
        * Name: generatePassengersButton_Click
        * Description: Generates a set number of passengers with random first and last names.
        * Input:
        * Output:
        ***************************************************************/
        private void generatePassengersButton_Click(object sender, EventArgs e)
        {
            string[] allFirstNames = File.ReadAllLines("RandomFirstNames.txt.");
            string[] allLastNames = File.ReadAllLines("RandomLastNames.txt.");
            Random rng = new Random();
            passengerList.Clear();
            clearPassengerListBox();
            clearQueueListBox();
            if (planeOneRadio.Checked)
            {
                for (int i = 0; i < planeOneSeats.Length; i++)
                {
                    passengerList.Add(new Passenger(allFirstNames[rng.Next(allFirstNames.Length)], allLastNames[rng.Next(allLastNames.Length)], planeOneSeats[i]));
                }
            }
            else if (planeTwoRadio.Checked)
            {
                for (int i = 0; i < planeTwoSeats.Length; i++)
                {
                    passengerList.Add(new Passenger(allFirstNames[rng.Next(allFirstNames.Length)], allLastNames[rng.Next(allLastNames.Length)], planeTwoSeats[i]));
                }
            }
            shuffle(passengerList); //Shuffle list to simulate random nature of passengers purchasing seating.
            updatePassengersListBox(passengerList);
        }
        /**************************************************************
        * Name: sortFirstNameButton_Click
        * Description: Sorts list of passengers by first name.
        * Input:
        * Output:
        ***************************************************************/
        private void sortFirstNameButton_Click(object sender, EventArgs e)
        {
            passengerList.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));
            clearPassengerListBox();
            updatePassengersListBox(passengerList);
        }
        /**************************************************************
        * Name: sortLastNameButton_Click
        * Description: Sorts list of passengers by last name.
        * Input:
        * Output:
        ***************************************************************/
        private void sortLastNameButton_Click(object sender, EventArgs e)
        {
            passengerList.Sort((x, y) => x.LastName.CompareTo(y.LastName));
            clearPassengerListBox();
            updatePassengersListBox(passengerList);
        }
        /**************************************************************
        * Name: sortSeatButton_Click
        * Description: Sorts list of passengers by seat.
        * Input:
        * Output:
        ***************************************************************/
        private void sortSeatButton_Click(object sender, EventArgs e)
        {
            clearPassengerListBox();
            List<Passenger> tempList = new List<Passenger>();
            if (passengerList.Count == PLANEONESIZE)
            {
                for (int i = 0; i < PLANEONESIZE; i++)
                {
                    for (int i2 = 0; i2 < passengerList.Count; i2++)
                    {
                        if (planeOneSeats[i] == passengerList[i2].Seat)
                        {
                            tempList.Add(passengerList[i2]);
                            break;
                        }
                    }
                }
            }
            else if (passengerList.Count == PLANETWOSIZE)
            {
                for (int i = 0; i < PLANETWOSIZE; i++)
                {
                    for (int i2 = 0; i2 < passengerList.Count; i2++)
                    {
                        if (planeTwoSeats[i] == passengerList[i2].Seat)
                        {
                            tempList.Add(passengerList[i2]);
                            break;
                        }
                    }
                }
            }
            passengerList = tempList;
            updatePassengersListBox(passengerList);
        }
        /**************************************************************
        * Name: queueButton_Click
        * Description: Creates a queue to board the plane based on selected method.
        * Input:
        * Output:
        ***************************************************************/
        private void queueButton_Click(object sender, EventArgs e)
        {
            clearQueueListBox();
            if (passengerList.Count == 0)
            {
                MessageBox.Show("Please generate customers before attempting to queue.");
                return;
            }
            else if (steffenPerfRadio.Checked && passengerList.Count == PLANEONESIZE)
            {
                printSteffenGroup(passengerList, steffenPerfPlaneOne, queue1ListBox);
            }
            else if (steffenPerfRadio.Checked && passengerList.Count == PLANETWOSIZE)
            {
                queue1ListBox.Items.Add("Top entrance queue: ");
                printSteffenGroup(passengerList, steffenPerfPlaneTwoQueueOne, queue1ListBox);
                queue2ListBox.Items.Add("Bottom entrance queue: ");
                printSteffenGroup(passengerList, steffenPerfPlaneTwoQueueTwo, queue2ListBox);
            }
            else if (steffenModRadio.Checked && passengerList.Count == PLANEONESIZE)
            {
                queue1ListBox.Items.Add("Boarding group 1:");
                printSteffenGroup(passengerList, steffenModPlaneOne1, queue1ListBox);
                queue1ListBox.Items.Add("");
                queue1ListBox.Items.Add("Boarding group 2:");
                printSteffenGroup(passengerList, steffenModPlaneOne2, queue1ListBox);
                queue2ListBox.Items.Add("Boarding group 3:");
                printSteffenGroup(passengerList, steffenModPlaneOne3, queue2ListBox);
                queue2ListBox.Items.Add("");
                queue2ListBox.Items.Add("Boarding group 4:");
                printSteffenGroup(passengerList, steffenModPlaneOne4, queue2ListBox);
            }
            else if (steffenModRadio.Checked && passengerList.Count == PLANETWOSIZE)
            {
                queue1ListBox.Items.Add("Boarding group 1A:");
                printSteffenGroup(passengerList, steffenModPlaneTwo1A, queue1ListBox);
                queue1ListBox.Items.Add("");
                queue1ListBox.Items.Add("Boarding group 2A:");
                printSteffenGroup(passengerList, steffenModPlaneTwo2A, queue1ListBox);
                queue1ListBox.Items.Add("");
                queue1ListBox.Items.Add("Boarding group 3A:");
                printSteffenGroup(passengerList, steffenModPlaneTwo3A, queue1ListBox);
                queue2ListBox.Items.Add("Boarding group 1B:");
                printSteffenGroup(passengerList, steffenModPlaneTwo1B, queue2ListBox);
                queue2ListBox.Items.Add("");
                queue2ListBox.Items.Add("Boarding group 2B:");
                printSteffenGroup(passengerList, steffenModPlaneTwo2B, queue2ListBox);
                queue2ListBox.Items.Add("");
                queue2ListBox.Items.Add("Boarding group 3B:");
                printSteffenGroup(passengerList, steffenModPlaneTwo3B, queue2ListBox);
            }
        }
        /**************************************************************
        * Name: shuffle
        * Description: Shuffles list
        * Input: List<T> inList
        * Output:
        ***************************************************************/
        private void shuffle<T>(List<T> inList)
        {
            Random rng = new Random();
            int n = inList.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = inList[k];
                inList[k] = inList[n];
                inList[n] = value;
            }
        }
        /**************************************************************
        * Name: updatePassengersListBox
        * Description: Updates list box to reflex list of passengers.
        * Input: List<Passenger> inList
        * Output:
        ***************************************************************/
        private void updatePassengersListBox(List<Passenger> inList)
        {
            foreach (Passenger p in inList)
            {
                passengerListBox.Items.Add(p.FirstName + " " + p.LastName + " " + p.Seat);
            }
        }
        /**************************************************************
        * Name: clearPassengersListBox
        * Description: Removes all items from passengerListBox
        * Input:
        * Output:
        ***************************************************************/
        private void clearPassengerListBox()
        {
            passengerListBox.Items.Clear();
        }
        /**************************************************************
        * Name: clearQueueListBox
        * Description: Removes all items from queueListBox
        * Input:
        * Output:
        ***************************************************************/
        private void clearQueueListBox()
        {
            queue1ListBox.Items.Clear();
            queue2ListBox.Items.Clear();
        }
        /**************************************************************
        * Name: printSteffenGroup
        * Description: Queues passengers according to selected order and updates list box.
        * Input: List<Passenger> inList, string[] inArray, ListBox inListBox
        * Output:
        ***************************************************************/
        private void printSteffenGroup(List<Passenger> inList, string[] inArray, ListBox inListBox)
        {
            for (int i = 0; i < inArray.Length; i++)
            {
                for (int i2 = 0; i2 < inList.Count; i2++)
                {
                    if (inArray[i] == inList[i2].Seat)
                    {
                        lineOneQueue.Enqueue(passengerList[i2]);
                        inListBox.Items.Add(passengerList[i2].FirstName + " " + passengerList[i2].LastName + " " + passengerList[i2].Seat);
                        break;
                    }
                }
            }
        }
        /**************************************************************
        * Name: planeOneRadio_CheckedChanged
        * Description: Changes image of plane
        * Input: 
        * Output:
        ***************************************************************/
        private void planeOneRadio_CheckedChanged(object sender, EventArgs e)
        {
            plane1PictureBox.Visible = true;
            plane2PictureBox.Visible = false;
        }
        /**************************************************************
        * Name: planeTwoRadio_CheckedChanged
        * Description: Changes image of plane
        * Input: 
        * Output:
        ***************************************************************/
        private void planeTwoRadio_CheckedChanged(object sender, EventArgs e)
        {
            plane2PictureBox.Visible = true;
            plane1PictureBox.Visible = false;
        }
        /**************************************************************
        * Name: exitButton_Click
        * Description: Closes the program.
        * Input: 
        * Output:
        ***************************************************************/
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

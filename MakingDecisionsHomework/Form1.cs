using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakingDecisionsHomework
{
    public partial class WorkshopSelector : Form
    {
        public WorkshopSelector()
        {
            InitializeComponent();
        }
        private void WorkshopSelector_Load(object sender, EventArgs e)
        {
            workshopListBox.SelectedIndex = 0;
            locationListBox.SelectedIndex = 0;   
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {           
            int[] days = new int[] { 3, 3, 3, 5, 1 };
            int[] registrationFees = new int[] { 1000, 800, 1500, 1300, 500 };
            int[] lodgingFees = new int[] { 150, 225, 175, 300, 175, 150 };

            int workshopIndex = workshopListBox.SelectedIndex;
            int locationIndex = locationListBox.SelectedIndex;

            int numDays = days[workshopIndex];
            int registrationFee = registrationFees[workshopIndex];
            int lodgingFee = lodgingFees[locationIndex];

            int lodgingTotal = lodgingFee * numDays;
            int total = registrationFee + lodgingTotal;

            registrationAnswerLabel.Text = registrationFee.ToString("C0");
            lodgingAnswerLabel.Text = $"{lodgingFee:C0} x {numDays} = {lodgingTotal:C0}";
            totalAnswerLabel.Text = total.ToString("C0");
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Rosa Munguia
 * Student No: 300735300
 * Date: August 3 2017
 * Description: Calculator Demo Project
 * Version 0.1: Created project
 * */
namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        //private InstanceCreationEditor variable
        private bool _isDecimalClicked;
        //public properties
        public bool IsDecimalClicked
        {
            get
            {
                return this._isDecimalClicked;
            }
            set
            {
                this._isDecimalClicked = value;
            }
        }
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CalculatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        /// <summary>
        /// Event handler for formClosing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//this closes the application
        }
       
        /// <summary>
        /// this is the shared event handler for the calculator buttons
        /// Not including the operator buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button calculatorButton = sender as Button; //downcasting

            if((calculatorButton.Text==".") && (this.IsDecimalClicked))
            {
                    return;
               
            }

            ResultTextBox.Text += calculatorButton.Text;

            //Debug.WriteLine("A calculator button was clicked");
        }
        /// <summary>
        /// This is the shared event handler for the operator buttons of the calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button operatorButton = sender as Button; //downcasting
        }
        /// <summary>
        /// this is the event handler for the "Load" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            this.IsDecimalClicked = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace TowersOfHanoi
{
    public partial class Form1 : Form
    {
        Simulation Hanoi = new Simulation();  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentStepLabel.Text = "";
            nextStepLabel.Text = "";
        }
        bool isPaused = true;
        int stepCounter = 0;
        bool button1FirstClick = true;
        Drawer drawer = new Drawer();
        private void moveOneDisk()
        {
            int sleepVal = Convert.ToInt32(stepsNumericUpDown.Value);
            if (Hanoi.steps.Count<=stepCounter)
            {
                MessageBox.Show("No more moves!");
                return;
            }
            currentStepLabel.Text = "Step " + (stepCounter + 1) + ": Move from " + Hanoi.steps[stepCounter][0] + " to " + Hanoi.steps[stepCounter][1] + ".";
            if (stepCounter + 1 <= Hanoi.steps.Count - 1)
            {
                nextStepLabel.Text = "Next : Move from " + Hanoi.steps[stepCounter + 1][0] + " to " + Hanoi.steps[stepCounter + 1][1] + "."; 
            }
            else
            {
                nextStepLabel.Hide();
            }
            Thread.Sleep(sleepVal);
            Hanoi.moveDisk2(Hanoi.steps[stepCounter]);
            updateDisks();
            stepCounter++;
            
        }
        
        private void addDisk(Disk disk)
        {
            Graphics g = gamePanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            SolidBrush sb = new SolidBrush(disk.color);
            int startAlignment = 0;
            if(disk.rod==1)
            {
                startAlignment = Hanoi.Bx - Hanoi.Ax;
            }
            else if (disk.rod==2)
            {
                startAlignment = Hanoi.Cx - Hanoi.Ax;
            }
            sb = new SolidBrush(disk.color);
            g.DrawRectangle(p, disk.startX + startAlignment, disk.startY, disk.width, disk.height);
            g.FillRectangle(sb, disk.startX + startAlignment, disk.startY, disk.width, disk.height);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Invalidate();
            drawer.drawRodBase(gamePanel);
            drawer.drawRods(gamePanel, Hanoi);
        }
        private void updateDisks()
        {
                gamePanel.Refresh();
                drawer.drawRodBase(gamePanel);
                drawer.drawRods(gamePanel, Hanoi);
                // panel1.Invalidate();
                for (int i = 0; i < Hanoi.A.Count; i++)
                {
                    addDisk(Hanoi.A[i]);
                }
                for (int i = 0; i < Hanoi.B.Count; i++)
                {
                    addDisk(Hanoi.B[i]);
                }
                for (int i = 0; i < Hanoi.C.Count; i++)
                {
                    addDisk(Hanoi.C[i]);
                }
                Thread.CurrentThread.IsBackground = true;
                

        }
        private void startButtonClick(object sender, EventArgs e)
        {
            if (button1FirstClick == true)
            {
                int numOfDisks = Convert.ToInt32(disksNumericUpDown.Text);
                gamePanel.Refresh();
                drawer.loadG(numOfDisks, Hanoi, gamePanel, Hanoi.GetRandom());
                updateDisks();
                Hanoi.TowersOfHanoi();
                button1FirstClick = false;


            }

            if (isPaused == false)
            {
                startButton.Text = "Resume";
                isPaused = true;
            }
            else
            {
                startButton.Text = "Pause";
                isPaused = false;

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    for (; stepCounter < Hanoi.steps.Count; )
                    {
                        if (isPaused == false)
                        {
                            moveOneDisk();
                        }
                        else
                        {
                            break;
                        }
                    }
                }).Start();
            }
        }

        private void nextStepButton_Click(object sender, EventArgs e)
        {


            if (button1FirstClick == true)
            {
                startButton.Text = "Resume";
                gamePanel.Refresh();
                int numOfDisks = Convert.ToInt32(disksNumericUpDown.Text);
                drawer.loadG(numOfDisks, Hanoi, gamePanel, Hanoi.GetRandom());
                updateDisks();
                Hanoi.TowersOfHanoi();
                button1FirstClick = false;

            }

            if (isPaused == false)
            {
                startButton.Text = "Resume";
                isPaused = true;

            }
            if (isPaused == true)
            {
                //button2.Text = "Pause";
                isPaused = false;

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    if (isPaused == false)
                    {
                        moveOneDisk();
                    }
                }).Start();
            }
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
            gamePanel.Refresh();
            gamePanel.Invalidate();
        } 
    }
}

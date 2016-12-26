using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TowersOfHanoi
{
    class Drawer
    {
        public void loadG(int disks,Simulation Hanoi,System.Windows.Forms.Panel panel,Random rnd)
        {
            int numOfDisks = disks;
            Hanoi.A.Clear();
            Hanoi.diskCount = numOfDisks;
            Disk disk = new Disk();
            disk.startX = (panel.Width / 12) + (panel.Width / 12) / 10;
            disk.startY = 9 * (panel.Height / 10) - (panel.Height / 50) - 5;
            disk.width = 9 * ((panel.Width / 12) * 2) / 10;
            disk.height = (panel.Height / 35);
            disk.rod = 0;
            disk.color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            for (int i = 0; i < numOfDisks; i++)
            {
                Hanoi.A.Add(disk);
                Hanoi.Ys.Add(disk.startY);
                Disk disk2 = new Disk();
                disk2.startX = disk.startX + disk.width / 20;
                disk2.startY = disk.startY - (panel.Height / 50) - 7;
                disk2.width = 9 * disk.width / 10;
                disk2.height = disk.height;
                disk2.rod = 0;
                disk2.color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                disk = disk2;
            }
        }
        public void drawRodBase(System.Windows.Forms.Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Black);
            int startX = panel.Width / 12;
            int startY = 9 * (panel.Height / 10);
            int width = (panel.Width / 12) * 2;
            int height = (panel.Height / 50);

            g.DrawRectangle(p, startX, startY, width, height);
            g.FillRectangle(sb, startX, startY, width, height);

            startX += panel.Width / 3;
            g.DrawRectangle(p, startX, startY, width, height);
            g.FillRectangle(sb, startX, startY, width, height);

            startX += panel.Width / 3;
            g.DrawRectangle(p, startX, startY, width, height);
            g.FillRectangle(sb, startX, startY, width, height);
        }
        public void drawRods(System.Windows.Forms.Panel panel,Simulation Hanoi)
        {
            Graphics g = panel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Black);

            int startY = panel.Height / 10;
            int width = (panel.Width / 70);
            int height = 8 * (panel.Height / 10);
            int startX = (2 * (panel.Width / 12));
            startX -= width / 2;

            g.DrawRectangle(p, startX, startY, width, height);
            g.FillRectangle(sb, startX, startY, width, height);
            Hanoi.Ax = startX;

            startX += panel.Width / 3;
            g.DrawRectangle(p, startX, startY, width, height);
            g.FillRectangle(sb, startX, startY, width, height);
            Hanoi.Bx = startX;

            startX += panel.Width / 3;
            g.DrawRectangle(p, startX, startY, width, height);
            g.FillRectangle(sb, startX, startY, width, height);
            Hanoi.Cx = startX;

        }

    }
}

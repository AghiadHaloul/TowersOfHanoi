using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TowersOfHanoi
{
    class Simulation
    {
        public List<Disk> A = new List<Disk>();
        public List<Disk> B = new List<Disk>();
        public List<Disk> C = new List<Disk>();
        public int Ax;
        public int Bx;
        public int Cx;
        public List<int> Ys = new List<int>();
        public int diskCount;
        public List<string> steps = new List<string>();
        public List<List<String>> memo = new List<List<string>>();
        static Random rnd;
        public void initializeMemo()
        {
            for(int i=0;i<100;i++)
            {
                //memo.Add(new List<string>());
            }
        }
        public Random GetRandom()
        {
            rnd = new Random();
            return rnd;
        }
        public void moveDisk2(string s)
        {
            List<Disk> source = new List<Disk>(), destination = new List<Disk>();
            int destinationRod;
            switch (s)
            {
                case "AB":
                    source = this.A;
                    destination = this.B;
                    destinationRod = 1;
                    break;

                case "AC":
                    source = this.A;
                    destination = this.C;
                    destinationRod = 2;
                    break;

                case "BA":
                    source = this.B;
                    destination = this.A;
                    destinationRod = 0;
                    break;

                case "BC":
                    source = this.B;
                    destination = this.C;
                    destinationRod = 2;
                    break;

                case "CA":
                    source = this.C;
                    destination = this.A;
                    destinationRod = 0;
                    break;

                case "CB":
                default:
                    source = this.C;
                    destination = this.B;
                    destinationRod = 1;
                    break;

            }
            if (source.Count == 0)
                return;
            Disk disk = source[source.Count - 1];
            disk.rod = destinationRod;
            disk.startY = Ys[destination.Count];
            destination.Add(disk);
            source.RemoveAt(source.Count - 1);
        }
        public void moveDisk(List<Disk> source, List<Disk> destination,int destinationRod)
        {
            if (source.Count == 0)
                return;
            Disk disk = source[source.Count - 1];
            //disk.rod = destinationRod;
            disk.startY = Ys[destination.Count];
            destination.Add(disk);
            source.RemoveAt(source.Count - 1);
        }
        public void TowersOfHanoi()
        {
            List<Disk> Atemp = new List<Disk>(this.A);
            List<Disk> Btemp = new List<Disk>(this.B);
            List<Disk> Ctemp = new List<Disk>(this.C);
            Solve(diskCount, this.A, this.C, this.B);
            this.A = Atemp;
            this.B = Btemp;
            this.C = Ctemp;
        }
        public void Solve(int count,List<Disk> source,List<Disk> target,List<Disk>aux)
        {
            
            if (count > 0)
            {
                Solve(count - 1, source, aux, target);
                this.moveDisk(source, target, 2);
                if(source == A && target == B)
                {
                    steps.Add("AB");
                }
                if (source == A && target == C)
                {
                    steps.Add("AC");
                }
                if (source == B && target == A)
                {
                    steps.Add("BA");
                }
                if (source == B && target == C)
                {
                    steps.Add("BC");
                }
                if (source == C && target == A)
                {
                    steps.Add("CA");
                }
                if (source == C && target == B)
                {
                    steps.Add("CB");
                }
                
                Solve(count - 1, aux, target, source);

            }
        }

        
    }
}

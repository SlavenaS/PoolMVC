using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool.Model
{
    class Pool
    {
        private double volume;
        private double pipe1Flow;
        private double pipe2Flow;
        private double hours;
        public double Volume
        {
            get { return volume; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ne moje pod 0 za obem");
                }

                this.volume = value;
            }
        }
        public double Hours
        {
            get { return hours; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ne moje pod 0 za chasove");
                }
                this.hours = value;
            }
        }
        public double PipeFlow1
        {
            get { return pipe1Flow; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ne moje pod 0 za truba 1");
                }
                this.pipe1Flow = value;
            }
        }
        public double PipeFlow2
        {
            get { return pipe2Flow; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ne moje pod 0 za truba 2");
                }
                this.pipe2Flow = value;
            }
        }

        public Pool() : this(0, 0, 0, 0) { } // Prazen konstruktor koito durji stoinosti dokato se napulni gavniq konstruktor
        public Pool(double volume, double pipeFlow1, double pipeFlow2, double hours)
        {
            this.Volume = volume;
            this.PipeFlow1 = pipeFlow1;
            this.PipeFlow2 = pipeFlow2;
            this.Hours = hours;
        }
        public double Pipe1MultiplyByhours() //truba 1 napulnila N litri
        {
            return pipe1Flow * hours;
        }
        public double Pipe2MultiplyByhours() //truba 2 napulnila N litri
        {
            return pipe2Flow * hours;
        }
        public double SumPipesFlow() // truba 1 i truba 2 obshto litri
        {
            return Pipe1MultiplyByhours() + Pipe2MultiplyByhours();
        }
        public double PercentageFlowFromPipe1AndPipe2FromVolume() // kolko procenta sa napulnili truba1 i truba2 ot celiq obem
        {
            return (SumPipesFlow() / volume) * 100;
        }

        public double Pipe1FlowPercentage() // kolko % e napulnila truba 1
        {
            return (Pipe1MultiplyByhours() / SumPipesFlow() * 100);
        }
        public double Pipe2FlowPercentage() // kolko % e napulnila truba 2
        {
            return (Pipe2MultiplyByhours() / SumPipesFlow() * 100);
        }
    }
}

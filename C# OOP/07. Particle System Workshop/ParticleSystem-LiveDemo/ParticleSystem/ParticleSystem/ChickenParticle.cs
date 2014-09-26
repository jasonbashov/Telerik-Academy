using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ChickenParticle : ChaoticParticle
    {
        const int MaxSpeedPerCoordinate = 2;

        public ChickenParticle(MatrixCoords position, MatrixCoords speed, Random randomGenerator)
            : base(position, speed, randomGenerator)
        {
            this.IsStopped = false;
        }

        public int TickCounter { get; protected set; }
        public int TicksToStay { get; protected set; }
        public bool IsStopped { get; protected set; }

        public override IEnumerable<Particle> Update()
        {
            //IEnumerable<Particle> objectsSoFar = base.Update();
            List<Particle> allGeneratedObjects = new List<Particle>();
            var result = new List<Particle>();

            if (!IsStopped)
            {
                IEnumerable<Particle> objectsSoFar = base.Update();
                if (this.randomGenerator.Next(0, 100) < 30)
                {
                    this.IsStopped = true;
                    this.TicksToStay = this.randomGenerator.Next(10);
                    //this.Speed = new MatrixCoords(0, 0);
                }
                allGeneratedObjects.AddRange(objectsSoFar);
                return allGeneratedObjects;
            }
            else
            {
                TickCounter++;
                if (this.TickCounter == this.TicksToStay)
                {
                    var createdSpeed = GetRandomCoords();

                    while (createdSpeed.Row == 0 && createdSpeed.Col == 0)
                    {
                        createdSpeed = GetRandomCoords();
                    }

                    this.TickCounter = 0;
                    this.IsStopped = false;
                    allGeneratedObjects.Add(GetNewParticle(this.Position, createdSpeed, this.randomGenerator));
                    IEnumerable<Particle> objectsSoFar = base.Update();
                    allGeneratedObjects.AddRange(objectsSoFar);
                    return allGeneratedObjects;
                }
                else
                {
                    return result;
                }
            }
        }
        protected MatrixCoords GetRandomCoords()
        {
            int randomSpeedRow =
                this.randomGenerator.Next(-MaxSpeedPerCoordinate, MaxSpeedPerCoordinate + 1);
            int randomSpeedCol =
                this.randomGenerator.Next(-MaxSpeedPerCoordinate, MaxSpeedPerCoordinate + 1);

            var createdSpeed = new MatrixCoords(
                    randomSpeedRow,
                    randomSpeedCol
                );
            return createdSpeed;
        }

        protected virtual Particle GetNewParticle(MatrixCoords position, MatrixCoords speed, Random randomGenerator)
        {
            return new ChickenParticle(position, speed, randomGenerator);
        }

        public override char[,] GetImage()
        {
            return new char[,] { { 'C' } };
        }
    }
}

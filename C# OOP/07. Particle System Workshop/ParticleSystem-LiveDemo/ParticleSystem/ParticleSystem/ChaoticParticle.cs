using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ChaoticParticle : Particle
    {
        protected Random randomGenerator;

        public ChaoticParticle(MatrixCoords position, MatrixCoords speed, Random randomGenerator)
            : base(position, speed)
        {
            this.randomGenerator = randomGenerator;
        }


        protected override void Move()
        {
            int newSpeed = randomGenerator.Next(-3,3);

            this.Speed += new MatrixCoords(newSpeed, newSpeed);

            this.Position += this.Speed;
        }

        public override char[,] GetImage()
        {
            return new char[,] { { '#' } };
        }
    }
}

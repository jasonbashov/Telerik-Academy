using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    class ParticleSystemMain
    {
        const int SimulationRows = 30;
        const int SimulationCols = 40;

        static readonly Random randomGenerator = new Random();

        static void Main(string[] args)
        {
            var renderer = new ConsoleRenderer(SimulationRows, SimulationCols);
            var particleOperator = new MoreAdvancedParticleOperator();

            var particles = new List<Particle>()
            {
                new Particle(new MatrixCoords(5, 5), new MatrixCoords(1, 1)),
                //new ParticleEmitter(new MatrixCoords(5, 10), new MatrixCoords(0, 0), RandomGenerator),
                //new ParticleEmitter(new MatrixCoords(5, 20), new MatrixCoords(0, 0), RandomGenerator),
                new VariousLifetimeParticleEmitter(new MatrixCoords(29, 1), new MatrixCoords(0, 0), randomGenerator),

                //new ParticleAttractor(new MatrixCoords(15, 8), new MatrixCoords(), 5),
                //new ParticleAttractor(new MatrixCoords(15, 20), new MatrixCoords(), 1),
                new ChaoticParticle(new MatrixCoords(10,10), new MatrixCoords(0,0), randomGenerator),
                new ChaoticParticle(new MatrixCoords(10,10), new MatrixCoords(0,0), randomGenerator),
                new ChaoticParticle(new MatrixCoords(10,10), new MatrixCoords(1,1), randomGenerator),
                new ChickenParticle(new MatrixCoords(10,10), new MatrixCoords(1,1), randomGenerator),
                new ParticleEmitter(new MatrixCoords(12,30), new MatrixCoords(0,0), randomGenerator),
                new ParticleRepeller(new MatrixCoords(12,20), new MatrixCoords(0,0), 3, 8),
            };

            var engine = new Engine(renderer, particleOperator, particles, 500);

            engine.Run();
        }
    }
}

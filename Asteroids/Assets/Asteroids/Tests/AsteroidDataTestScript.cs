using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Script
{
    
    public class AsteroidDataTestScript
    {

        private AsteroidData asteroid;
        // A Test behaves as an ordinary method

        [Test]
        public void AsteroidDataTestScriptSimplePasses()
        {
            asteroid = new AsteroidData();

            Assert.IsNull(asteroid);
            // Use the Assert class to test conditions
        }    
        
        [Test]
        public void GetPointsSimplePasses()
        {
            asteroid = new AsteroidData();
            var x = asteroid.GetPoints();
            Assert.AreEqual(x, 20);
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [Test]
        public IEnumerator AsteroidDataTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }

}

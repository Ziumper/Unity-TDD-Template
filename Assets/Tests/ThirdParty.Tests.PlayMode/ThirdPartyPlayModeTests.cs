using System.Collections;
using UnityEngine.TestTools;

namespace ThirdParty.Tests.PlayMode
{
    public class ThirdPartyPlayModeTests
    {
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator ThirdPartyTestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }

}

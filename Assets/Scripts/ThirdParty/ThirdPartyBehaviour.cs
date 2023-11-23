using UnityEngine;

namespace ThirdParty
{

    /// <summary>
    /// Some external mono behaviour
    /// </summary>
    public class ThirdPartyBehaviour : MonoBehaviour
    {
        //hidden memebers
        private ICalculator _calcuator;
        private IAdder _adder;

        //instance created by editor
        [SerializeField] private Calculator _calcuatorInstance;


        /// <summary>
        /// Used paramless constructor to initalize hidden members in Unity editor
        /// or use SerializeField to make Unity create an instance for you inside editor
        /// </summary>
        public ThirdPartyBehaviour()
        {
            //providing my instance of Adder
            _adder = new MultiplyFirstBBy5Adder();
            _calcuator = new Calculator(_adder);
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}

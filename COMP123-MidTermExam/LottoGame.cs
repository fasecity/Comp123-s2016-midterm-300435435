﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * 
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
    {
        
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private List<int> _elementList;
        private int _elementNumber;
        private List<int> _numbersList;
        private Random _random;
        private int _setSize;
        // CREATE private fields here --------------------------------------------

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public List<int> ElementList { get
            { return this._elementList; }

        }
        public int ElementNumber { get { return this._elementNumber; } set { this._elementNumber = value; ;} }
        public List<int> NumberList { get{return this._numbersList;} set{ this._numbersList=value;} }
        public Random random { get {return this._random ;} }
        public int SetSize { get { return this._setSize; } set { this._setSize = value; } }
        // CREATE public properties here -----------------------------------------

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this._initialize();

            // call the _build method
            this._build();
        }

        public int Property
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



       

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        
        // OVERRIDEN METHODS +++++++++++++++++++++++++
        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
            {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }

            return lottoNumberString;
        }
        /// <summary>
        /// Private build method 
        /// @ return void
        /// </summary>
        private void _build()
        {
            for (int i = 1; i < SetSize+1; i++)
            {
                NumberList.Add(i);
            }
        }
        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        
        /// <summary>
        /// Public initialize method initializes lists and random
        /// @retun void
        /// </summary>
        public void _initialize()
        {
            _numbersList = new List<int>();
            _elementList = new List<int>();
            _random = new Random();
        }
        /// <summary>
        /// Pickelement public GenerateLottoNumbers 
        /// @ retun void
        /// </summary>
       
        
        public void PickElements()
        {
         
            
            if (this.ElementList.Count > 0)
            {
                ElementList.Clear();
                NumberList.Clear();
            }
            _build();


            int randomNumber = random.Next(1,SetSize+1);
           NumberList.RemoveAt(randomNumber);
           int L = randomNumber + ElementList.Count;

           for (int i = 0; i < ElementNumber; i++)
           {
                   randomNumber = random.Next(1,SetSize+1);
           NumberList.RemoveAt(randomNumber);
           int l = randomNumber + ElementList.Count;
           }

           ElementList.Sort();


         
        }


        // CREATE the public PickElements method here ----------------------------
    }
}

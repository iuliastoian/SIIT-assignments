using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuliaTiaStoian_ClassesWithLight
{
    internal class BecReglabil
    {
        private int _currentPower;
        private int _maxPower;

        public int CurrentPower {  get { return _currentPower; } }
        public int MaxPower { get { return _maxPower; } }

        public bool Aprins { get { return _currentPower > 0; } }

        public BecReglabil(int power, int maxPower)
        {
            _currentPower = power;
            _maxPower = maxPower;
        }

        public void Aprinde() { _currentPower = _maxPower; }
        public void Stinge() { _currentPower = 0; }
        public void MaresteLumina(int value)
        {
            _currentPower += value;
            if (_currentPower > _maxPower) { _currentPower = _maxPower; }
        }
        public void ReduceLumina(int value)
        {
            _currentPower -= value;
            if (_currentPower < 0) {  _currentPower = 0; }
        }

    }
}

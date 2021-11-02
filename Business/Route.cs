using System;

namespace Business
{
    public class Route
    {
        #region velden
        private int _ritId;
        private int _vertrekUur;
        private int _vertrekMinuut;
        private String _aankomstStation;
        private int _aankomstUur;
        private int _aankomstMinuut;
        private int _afstand;
        private int _enkelWeek;
        #endregion

        #region constructor
        public Route(int ritId,
                    int vertrekUur,
                    int vertrekMinuut,
                    string aankomstStation,
                    int aankomstUur,
                    int aankomstMinuut,
                    int afstand,
                    int enkelWeek)
        {
            _ritId = ritId;
            _vertrekUur = vertrekUur;
            _vertrekMinuut = vertrekMinuut;
            _aankomstStation = aankomstStation;
            _aankomstUur = aankomstUur;
            _aankomstMinuut = aankomstMinuut;
            _afstand = afstand;
            _enkelWeek = enkelWeek;
        }
        #endregion

        #region properties
        public int VertrekUur { get => _vertrekUur; set => _vertrekUur = value; }
        public int VertrekMinuut { get => _vertrekMinuut; set => _vertrekMinuut = value; }
        public string AankomstStation { get => _aankomstStation; set => _aankomstStation = value; }
        public int AankomstUur { get => _aankomstUur; set => _aankomstUur = value; }
        public int AankomstMinuut { get => _aankomstMinuut; set => _aankomstMinuut = value; }
        public int Afstand { get => _afstand; set => _afstand = value; }
        public int EnkelWeek { get => _enkelWeek; set => _enkelWeek = value; }
        public int RitId { get => _ritId; set => _ritId = value; }
        #endregion

        public String ToonVertrekUur()
        {
            if(_vertrekMinuut < 10)
            {
                return $"{_vertrekUur}:0{_vertrekMinuut}";
            } else
            {
                return $"{_vertrekUur}:{_vertrekMinuut}";
            }
            
        } 
        public String ToonAankomstUur()
        {
            if(_aankomstMinuut < 10)
            {
                return $"{_aankomstUur}:0{_aankomstMinuut}";
            } else
            {
                return $"{_aankomstUur}:{_aankomstMinuut}";
            }
        }

        public override string ToString()
        {
            return $"{ToonVertrekUur()} | IEPER --> {AankomstStation.ToUpper()} | {ToonAankomstUur()}";
        }
    }
}

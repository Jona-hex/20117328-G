namespace DogKeepers.Shared.CustomEntities
{
    public class Pagination
    {
        private int? _PageNumber { get; set; }

        private int? _PageSize { get; set; }
        public int? PageNumber { 
            get {return _PageNumber; }
            set {_PageNumber = _PageNumber ?? value; }
        }
           public int? PageSize { 
            get {return _PageSize; }
            set {_PageSize = _PageSize ?? value; }
        }
        public int? PageNumberForce {
             get {return _PageNumber; }
            set {_PageNumber = value; }
    }
    }
}
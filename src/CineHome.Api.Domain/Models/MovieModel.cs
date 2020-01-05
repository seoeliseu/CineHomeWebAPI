using System;

namespace CineHome.Api.Domain.Models
{
    public class MovieModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private DateTime _createAt;
        public DateTime CreateAt
        {
            get { return _createAt; }
            set { _createAt = value == null ? DateTime.UtcNow : value; }
        }

        private string _originalTitle;
        public string OriginalTitle
        {
            get { return _originalTitle; }
            set { _originalTitle = value; }
        }

        private string _nationalTitle;
        public string NationalTitle
        {
            get { return _nationalTitle; }
            set { _nationalTitle = value; }
        }

        private int _durationMinutes;
        public int DurationMinutes
        {
            get { return _durationMinutes; }
            set { _durationMinutes = value; }
        }

        private int _releaseYear;
        public int ReleaseYear
        {
            get { return _releaseYear; }
            set { _releaseYear = value; }
        }


    }
}

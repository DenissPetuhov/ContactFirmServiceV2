using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactFirmService.BLL
{
    public class SbFirmTypeCol :IEnumerable
    {
        public SbFirmTypeCol(List<SbFirmType> sbFirmTypes) => this.Lst = sbFirmTypes;
        public int Count
        {
            get
            {
                Count = Lst.Count;
                return Count;
            }
            private set => Count = value;
        }
        private List<SbFirmType> Lst;
        public SbFirmType Current
        {
            get
            {
                if (Count == 0 || Count >= Lst.Count)
                    throw new ArgumentException();
                return Lst[Count];
            }
        }

        public IEnumerator GetEnumerator()=>Lst.GetEnumerator();
      


        //object IEnumerator.Current => throw new NotImplementedException();

        //public void Dispose() { }


        //public bool MoveNext()
        //{
        //    if (Count < Lst.Count)
        //    {
        //        Count++;
        //        return true;
        //    }
        //    return false;   
        //}

        //public void Reset()=>Count = 0;

    }
}

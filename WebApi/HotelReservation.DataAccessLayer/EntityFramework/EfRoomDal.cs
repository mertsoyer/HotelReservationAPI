using HotelReservation.DataAccessLayer.Abstract;
using HotelReservation.DataAccessLayer.Concrete;
using HotelReservation.DataAccessLayer.Repositories;
using HotelReservation.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.DataAccessLayer.EntityFramework
{
    public class EfRoomDal : GenericRepository<Room>, IRoomDal
    {
        public EfRoomDal(Context context) : base(context)
        {
        }
    }
}

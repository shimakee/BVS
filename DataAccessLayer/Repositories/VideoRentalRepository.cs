using BusinessLayer.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class VideoRentalRepository : Repository<VideoRental>, IVideoRentalRepository
    {
        public VideoRentalRepository(PlutoContext context)
            : base(context)
        {

        }
    }
}

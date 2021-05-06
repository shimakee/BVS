using BusinessLayer.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class VideoRepository : Repository<Video>, IVideoRepository
    {
        public VideoRepository(PlutoContext context)
            : base(context)
        {

        }
    }
}

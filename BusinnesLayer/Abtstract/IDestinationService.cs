﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Abtstract
{
    public interface IDestinationService : IGenericService<Destination>
    {
        Destination TGetDestinationWithGuide(int id);
        List<Destination> TGetLast4Destinations();
    }
}

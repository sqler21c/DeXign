﻿using Phlet.Core.Controls;

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Phlet.Core.Collections
{
    public class PControlCollection : ObservableCollection<PControl>
    {
        public PControlCollection()
        {
        }

        public PControlCollection(IEnumerable<PControl> collection) : base(collection)
        {
        }

        public PControlCollection(List<PControl> list) : base(list)
        {
        }
    }
}
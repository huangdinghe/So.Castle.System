using So.Castle.Domain;
using So.Castle.Manager;
using So.Castle.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace So.Castle.Component
{
  public  class VideoComponent : BaseComponent<Video, VideoManager>, IVideoService
    {
    }
}

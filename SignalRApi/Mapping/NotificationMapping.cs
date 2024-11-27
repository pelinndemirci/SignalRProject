using AutoMapper;
using SignalRDtoLayer.NotificationDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class NotificationMapping:Profile
    {
        public NotificationMapping()
        {
            CreateMap<Notification, ResultNotificationDto>();
            CreateMap<Notification, CreateNotificationDto>();
            CreateMap<Notification, UpdateNotificationDto>();
            CreateMap<Notification, GetNotificationDto>();
        }
    }
}

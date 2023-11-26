using AutoMapper;

namespace Application.Common.Mappings.Core
{
    public interface IMapFrom<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}

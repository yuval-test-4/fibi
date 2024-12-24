using EventsWorker.APIs.Common;
using EventsWorker.APIs.Dtos;

namespace EventsWorker.APIs;

public interface IEventDataService
{
    /// <summary>
    /// Create one EventDatum
    /// </summary>
    public Task<EventDatum> CreateEventDatum(EventDatumCreateInput eventdatum);

    /// <summary>
    /// Delete one EventDatum
    /// </summary>
    public Task DeleteEventDatum(EventDatumWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many EventData
    /// </summary>
    public Task<List<EventDatum>> EventData(EventDatumFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about EventDatum records
    /// </summary>
    public Task<MetadataDto> EventDataMeta(EventDatumFindManyArgs findManyArgs);

    /// <summary>
    /// Get one EventDatum
    /// </summary>
    public Task<EventDatum> EventDatum(EventDatumWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one EventDatum
    /// </summary>
    public Task UpdateEventDatum(
        EventDatumWhereUniqueInput uniqueId,
        EventDatumUpdateInput updateDto
    );

    /// <summary>
    /// Get a Group record for EventDatum
    /// </summary>
    public Task<Group> GetGroup(EventDatumWhereUniqueInput uniqueId);
}

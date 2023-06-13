namespace IwantApp.Controllers.Endpoint.Orders;

public record OrderRequest(List<Guid> ProductIds, string DeliveryAddress);
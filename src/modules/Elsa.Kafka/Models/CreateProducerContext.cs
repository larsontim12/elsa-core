namespace Elsa.Kafka;

public record CreateProducerContext(ProducerDefinition ProducerDefinition, SchemaRegistryDefinition? SchemaRegistryDefinition);
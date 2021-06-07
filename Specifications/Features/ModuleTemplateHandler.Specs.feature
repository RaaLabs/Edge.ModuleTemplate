Feature: ModuleTemplateHandler
    Testing the handler

    Background: Given a handler
        Given a handler of type ModuleTemplateHandler

    Scenario: Received contiunes stream of timeseries
        When the following events of type ModuleTemplateDatapointInput is produced
            | TimeSeries                           | Timestamp     | Value |
            | ba1b7c4f-de11-4f94-a750-2c2dabce7e16 | 1620000000000 | 3.14  |
            | ba1b7c4f-de11-4f94-a750-2c2dabce7e16 | 1620000001000 | 3.14  |
            | ba1b7c4f-de11-4f94-a750-2c2dabce7e16 | 1620000002000 | 3.14  |
            | ba1b7c4f-de11-4f94-a750-2c2dabce7e16 | 1620000003000 | 3.14  |
            | ba1b7c4f-de11-4f94-a750-2c2dabce7e16 | 1620000500000 | 3.14  |
            | ba1b7c4f-de11-4f94-a750-2c2dabce7e16 | 1620000910000 | 3.14  |
        Then the following events of type ModuleTemplateDatapointOutput is produced
            | TimeSeries                           | Timestamp     | Value |
            | ba1b7c4f-de11-4f94-a750-2c2dabce7e16 | 1620000000000 | 3.14  |
            | ba1b7c4f-de11-4f94-a750-2c2dabce7e16 | 1620000001000 | 3.14  |
            | ba1b7c4f-de11-4f94-a750-2c2dabce7e16 | 1620000002000 | 3.14  |
            | ba1b7c4f-de11-4f94-a750-2c2dabce7e16 | 1620000003000 | 3.14  |
            | ba1b7c4f-de11-4f94-a750-2c2dabce7e16 | 1620000500000 | 3.14  |
            | ba1b7c4f-de11-4f94-a750-2c2dabce7e16 | 1620000910000 | 3.14  |

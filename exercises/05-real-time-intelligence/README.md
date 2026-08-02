# Exercise 05: Real-Time Intelligence

## Objective

Learn how Microsoft Fabric processes streaming data.

## Scenario

A business wants real-time sales monitoring.

## Tasks

1. Create an Eventstream
2. Ingest sample events
3. Create an Eventhouse
4. Query data using KQL
5. Build a Real-Time Dashboard

## Sample Query

```kusto
SalesEvents
| summarize TotalRevenue = sum(Amount)
```

## Deliverables

- Eventstream screenshot
- Dashboard screenshot
- Query screenshot

## Success Criteria

- Streaming data visible
- KQL query works
- Dashboard updates

## Learning Notes

-
-
-

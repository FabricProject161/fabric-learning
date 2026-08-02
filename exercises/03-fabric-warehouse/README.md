# Exercise 03: Build a Data Warehouse

## Objective

Learn data warehouse fundamentals in Microsoft Fabric.

## Scenario

Sales data from the Lakehouse must be transformed into a star schema.

## Tasks

### Task 1: Create Warehouse

Create:

```text
SalesWarehouse
```

### Task 2: Create Dimension Table

```sql
CREATE TABLE DimProduct (
    ProductID INT,
    ProductName VARCHAR(100)
);
```

### Task 3: Create Fact Table

```sql
CREATE TABLE FactSales (
    OrderID INT,
    ProductID INT,
    Amount DECIMAL(18,2)
);
```

### Task 4: Insert Test Data

Load several records.

### Task 5: Create Report Query

```sql
SELECT
    ProductID,
    SUM(Amount) AS Revenue
FROM FactSales
GROUP BY ProductID;
```

## Deliverables

- Warehouse screenshot
- Tables screenshot
- Query result screenshot

## Success Criteria

- Warehouse created
- Tables created
- Query returns data

## Learning Notes

-
-
-

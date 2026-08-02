# Exercise 01: Create Your First Lakehouse

## Objective

Learn the fundamentals of Microsoft Fabric Lakehouse storage and data ingestion.

## Prerequisites

- Microsoft Fabric trial or Fabric-enabled workspace
- GitHub repository created
- Basic knowledge of SQL

## Scenario

You have received a CSV file containing sales transactions.

Your task is to:

1. Create a Lakehouse
2. Upload the data
3. Create Delta tables
4. Query the data using SQL

## Tasks

### Task 1: Create a Workspace

Create a workspace called:

```text
Fabric-Learning
```

### Task 2: Create a Lakehouse

Create a Lakehouse called:

```text
SalesLakehouse
```

### Task 3: Upload Sample Data

Create a file called:

```text
sales.csv
```

Sample data:

| OrderID | Product | Amount |
|----------|----------|----------|
| 1 | Laptop | 1200 |
| 2 | Mouse | 25 |
| 3 | Keyboard | 80 |

Upload the file to:

```text
Files/uploads/
```

### Task 4: Create a Table

Load the CSV into a managed table.

Table name:

```text
Sales
```

### Task 5: Query Data

Execute:

```sql
SELECT *
FROM Sales;
```

### Task 6: Calculate Revenue

```sql
SELECT SUM(Amount) AS Revenue
FROM Sales;
```

## Deliverables

- Screenshot of Lakehouse
- Screenshot of SQL query
- Screenshot of Sales table

## Success Criteria

- Lakehouse created
- Data uploaded
- SQL query executed successfully

## Notes

Document anything you learned during the exercise below.

### Learning Notes

-
-
-

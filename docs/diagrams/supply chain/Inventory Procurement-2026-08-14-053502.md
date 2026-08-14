# Inventory Management Diagrams

## Diagram 1 — Inventory Flow

```mermaid
flowchart LR
    A[Inventory Planning & Forecasting]
    B["Procurement<br/>(Purchase Orders)"]
    C[Receiving & Inspection]
    D[Storage & Warehouse Locations]
    E["Inventory Control<br/>(Tracking, Adjustments, Cycle Counts)"]
    F["Order Fulfillment<br/>(Picking, Packing)"]
    G[Shipping & Delivery]
    H[Inventory Reporting & KPIs]

    A --> B
    B --> C
    C --> D
    D --> E
    E --> F
    F --> G
    G --> H


flowchart LR
    A[Inventory planning & forecasting] --> B[Procurement]
    B --> C[Receiving & inspection]
    C --> D[Storage & warehousing]
    D --> E[Inventory control]
    E --> F[Order fulfillment]
    F --> G[Shipping & delivery]
    G --> H[Inventory analysis & reporting]
    A --> A1[Set inventory targets]
    A --> A2[Determine reorder points]
    A --> A3[Define safety stock levels]

    B --> B1[Create purchase orders]
    B --> B2["Use replenishment parameters<br/>(reorder points, lead times, agreements)"]

    C --> C1[Inspect goods for quality & accuracy]
    C --> C2[Record receipts & update inventory]
    C --> C3[Handle discrepancies via quality control]

    D --> D1[Assign warehouses & locations]
    D --> D2[Optimize storage & movement]

    E --> E1[Lot & serial tracking]
    E --> E2[Expiration date tracking]
    E --> E3[Inventory adjustments & cycle counts]

    F --> F1[Generate picking lists / transfer orders]
    F --> F2[Pick, pack, prepare for shipment]
    F --> F3[Update inventory in real time]

    G --> G1[Generate packing slips & labels]
    G --> G2[Ship or transfer orders]
    G --> G3[Update shipment status & tracking]

    H --> H1[Monitor KPIs & inventory metrics]
    H --> H2[Analyze turnover, stock levels, accuracy, costs]
    H --> H3[Identify improvements & optimize processes]

```mermaid
---
config:
  layout: elk
---
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
    
    classDef planning stroke #818cf8, fill #eef2ff
    classDef procurement stroke #2dd4bf, fill #f0fdfa
    classDef receiving stroke #a78bfa, fill #f5f3ff
    classDef storage stroke #fb923c, fill #fff7ed
    classDef control stroke #22d3ee, fill #ecfeff
    classDef fulfillment stroke #4ade80, fill #f0fdf4
    classDef shipping stroke #facc15, fill #fefce8
    classDef reporting stroke #f87171, fill #fef2f2
    
    class A planning
    class B procurement
    class C receiving
    class D storage
    class E control
    class F fulfillment
    class G shipping
    class H reporting
	
```mermaid
---
config:
  layout: dagre
---
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

    classDef stageMain stroke:#818cf8,fill:#eef2ff
    classDef stageDetail stroke:#a78bfa,fill:#f5f3ff
    class A,B,C,D,E,F,G,H stageMain
    class A1,A2,A3,B1,B2,C1,C2,C3,D1,D2,E1,E2,E3,F1,F2,F3,G1,G2,G3,H1,H2,H3 stageDetail
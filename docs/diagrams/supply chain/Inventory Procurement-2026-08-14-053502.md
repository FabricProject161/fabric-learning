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
# Inventory Management Diagrams

## Inventory Dimensions

```mermaid
%%{
  init: {
    'themeVariables': {
      'fontSize': '24px',          /* ~300% zoom */
      'lineHeight': '28px'
    },
    'flowchart': {
      'diagramPadding': 120,       /* increases outer box */
      'rankSpacing': 140,          /* increases vertical height */
      'nodeSpacing': 120,          /* increases horizontal spacing */
      'htmlLabels': false
    }
  }
}%%

flowchart TD

    %% Force wider nodes (simulates zoom)
    classDef big width:300px;

    A[Configure Inventory Dimensions<br/>D365 Supply Chain Management]:::big --> B[Design Dimension Model]:::big
    B --> C[Product Dimensions]:::big
    B --> D[Storage Dimensions]:::big
    B --> E[Tracking Dimensions]:::big
    B --> F[Physical & Packing Dimensions]:::big
    B --> G[Version Dimension]:::big

    %% Product dimensions
    C --> C1[Configuration]:::big
    C --> C2[Size]:::big
    C --> C3[Style]:::big
    C --> C4[Color]:::big

    %% Storage dimensions
    D --> D1[Warehouse storage behavior]:::big
    D --> D2[Volumetrics & capacity]:::big
    D --> D3[Location fit validation]:::big

    %% Tracking dimensions
    E --> E1[Batch number]:::big
    E --> E2[Serial number]:::big
    E --> E3[Traceability & warranty]:::big

    %% Physical & packing
    F --> F1[Storage physical dimension]:::big
    F --> F2[Packing dimension]:::big
    F --> F3[Nested packing]:::big
    F1 --> F11[Weight / Depth / Height / Width / Volume]:::big
    F2 --> F21[Containerization]:::big
    F3 --> F31[Multi‑level packing]:::big

    %% Version dimension
    G --> G1[Enable in license configuration]:::big
    G --> G2[Configure version groups]:::big
    G --> G3[Track product lifecycle versions]:::big

    %% Business goals
    A --> H[Business Goals]:::big
    H --> H1[Accurate inventory behavior]:::big
    H --> H2[Optimized warehouse & packing]:::big
    H --> H3[Strong traceability & compliance]:::big
    H --> H4[Controlled product versions]:::big

    %% Business risks
    A --> I[Business Risks]:::big
    I --> I1[Incorrect dimension setup → picking errors]:::big
    I --> I2[Missing tracking → recall issues]:::big
    I --> I3[Wrong physical data → capacity/packing failures]:::big
    I --> I4[No version tracking → lifecycle confusion]:::big
```

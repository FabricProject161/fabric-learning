# Publish & Receive Events with Azure Event Grid

This project demonstrates how to build an event‑driven workflow using **Azure Event Grid** and a Python Flask application. The scenario simulates an AI content‑moderation pipeline that publishes events, receives them through pull delivery, and processes them using acknowledge and reject operations.

Azure Event Grid acts as the routing layer that directs events to the correct consumers based on event type [sec2](#sentenceindex-sec2).  
The exercise includes deploying an Event Grid Namespace, creating filtered subscriptions, and completing a Python client that interacts with Event Grid using CloudEvents.

---

## 🎓 Microsoft Learning
Process messages with Azure Service Bus | Develop AI Cloud Solutions on Microsoft Azure<img width="559" height="19" alt="image" src="https://github.com/user-attachments/assets/bcaf0224-fc32-4aa8-870d-5b47fa478531" />

---

## 📦 Project Overview

The solution consists of:

- An Event Grid Namespace with a CloudEvents‑enabled topic [sec23](#sentenceindex-sec23)  
- Three filtered event subscriptions for flagged, approved, and all events [sec26](#sentenceindex-sec26)[sec27](#sentenceindex-sec27)[sec28](#sentenceindex-sec28)  
- A Flask application that publishes moderation events and retrieves them using pull delivery [sec3](#sentenceindex-sec3)  
- Functions to publish, receive, acknowledge, and reject events [sec5](#sentenceindex-sec5)

This exercise takes approximately **30 minutes** to complete [sec7](#sentenceindex-sec7).

---

## 🛠 Prerequisites

You will need:

- An Azure subscription [sec8](#sentenceindex-sec8)  
- Visual Studio Code [sec9](#sentenceindex-sec9)  
- Python **3.12+** [sec9](#sentenceindex-sec9)  
- Azure CLI with the Event Grid extension installed [sec20](#sentenceindex-sec20)

---

## 📁 Starter Files & Deployment

1. **Download the starter project** from the provided GitHub link [sec13](#sentenceindex-sec13).  
2. **Unzip the project** and open it in VS Code [sec14](#sentenceindex-sec14)[sec15](#sentenceindex-sec15).  
3. Update the deployment script with your resource group and region [sec17](#sentenceindex-sec17).  
4. Register the Event Grid resource provider and install the CLI extension [sec19](#sentenceindex-sec19)[sec20](#sentenceindex-sec20).  
5. Run the deployment script to:
   - Create the namespace and topic [sec23](#sentenceindex-sec23)
   - Create filtered subscriptions [sec26](#sentenceindex-sec26)
   - Assign sender/receiver roles [sec30](#sentenceindex-sec30)
   - Generate environment variable files [sec31](#sentenceindex-sec31)

---

## 🧩 Application Structure

The project includes:

- `app.py` — Flask UI that triggers publish/receive/reject operations [sec38](#sentenceindex-sec38)  
- `event_grid_functions.py` — Functions you complete to interact with Event Grid [sec39](#sentenceindex-sec39)  
- `moderation_events.json` — Sample CloudEvents definitions [sec43](#sentenceindex-sec43)

---

## 🚀 Features

### 1. Publish Moderation Events
Five CloudEvents are published to the namespace topic, representing flagged, approved, and escalated reviews [sec42](#sentenceindex-sec42].  
Each event receives a unique ID and timestamp at publish time [sec45](#sentenceindex-sec45].

### 2. Receive & Acknowledge Events
Pull delivery retrieves events from each subscription.  
Each event includes a lock token that must be acknowledged to remove it from the subscription [sec52](#sentenceindex-sec52][sec56](#sentenceindex-sec56).

Expected behavior:

- **Flagged subscription** → only flagged events [sec85](#sentenceindex-sec85)  
- **Approved subscription** → only approved events [sec86](#sentenceindex-sec86)  
- **All‑events subscription** → all published events [sec87](#sentenceindex-sec87)

### 3. Inspect & Reject Event
A test event is published, retrieved, inspected, and then rejected [sec61](#sentenceindex-sec61][sec66](#sentenceindex-sec66].  
Rejected events are discarded or moved to dead‑letter storage if configured [sec64](#sentenceindex-sec64].

---

## ▶️ Running the App

1. Navigate to the client directory [sec71](#sentenceindex-sec71).  
2. Create and activate a virtual environment [sec72](#sentenceindex-sec72].  
3. Install dependencies:

   ```bash
   pip install -r requirements.txt
   ```

4. Start the Flask app:
  ```bash
  python app.py
  ```

5. Open http://localhost to access the UI

## 🧹 Cleanup
Delete the resource group to remove all deployed Azure resources:
   ```bash
   az group delete --name <rg-name> --no-wait --yes
   ```
##  🩺 Troubleshooting
Common checks include:
- Namespace provisioning state is Succeeded sec97
- All three subscriptions exist and show Succeeded sec100
- Environment variables are loaded correctly sec106
- Azure CLI authentication is active sec109
- Python environment is activated and dependencies installed sec112

# Process Messages with Azure Service Bus
Develop AI Cloud Solutions on Microsoft Azure
https://microsoftlearning.github.io/mslearn-azure-ai/instructions/integrate-services/01-svcbus-process-messages.html

Azure Service Bus enables reliable messaging patterns for AI workflows.  
This exercise demonstrates queue messaging, dead‑lettering, and topic subscriptions using a Python Flask app.

---

## 🧩 Exercise Overview
You will:
- Download project starter files  
- Deploy an Azure Service Bus namespace  
- Add messaging code to a Python app  
- Run the app to send and process messages  
- Inspect the dead‑letter queue  
- Test topic messaging with filtered subscriptions  

Estimated time: ~30 minutes.

---

# 1. Prerequisites
- Azure subscription  
- Visual Studio Code  
- Python 3.12+  
- Azure CLI  

---

# 2. Download Starter Files & Deploy Azure Service Bus

## 2.1 Download Starter ZIP
```
https://github.com/MicrosoftLearning/mslearn-azure-ai/raw/main/downloads/python/service-bus-python.zip
```

Unzip and open in VS Code.

---

## 2.2 Configure Deployment Script
Edit the two variables:
```
"<your-resource-group-name>"
"<your-azure-region>"
```

---

## 2.3 Login & Register Provider
```bash
az login
az provider register --namespace Microsoft.ServiceBus
```

---

## 2.4 Run Deployment Script
Bash:
```bash
bash azdeploy.sh
```

PowerShell:
```powershell
./azdeploy.ps1
```

If blocked:
```powershell
Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass
```

---

## 2.5 Deployment Steps
1. Create namespace (Standard tier)  
2. Create queue, topic, subscriptions, SQL filter  
3. Assign Azure Service Bus Data Owner role  
4. Check deployment status  
5. Retrieve connection info  
6. Exit  

Load environment variables:

Bash:
```bash
source .env
```

PowerShell:
```powershell
. .\.env.ps1
```

---

# 3. Complete the App

Open:
```
client/service_bus_functions.py
```

Add code in the marked sections.

---

## 3.1 Send Messages to Queue
Three messages:
- Two valid JSON inference requests  
- One intentionally malformed JSON → DLQ  

```python
def send_messages():
    """Send messages to the queue including one malformed message."""
    # ...
```

---

## 3.2 Process Messages (Peek‑Lock)
Valid JSON → complete  
Invalid JSON → dead‑letter  

```python
def process_messages():
    """Receive and process messages from the queue using peek-lock."""
    # ...
```

---

## 3.3 Inspect Dead‑Letter Queue
Reads:
- dead_letter_reason  
- error_description  
- delivery_count  

```python
def inspect_dead_letter_queue():
    """Inspect and remove messages from the dead-letter queue."""
    # ...
```

---

## 3.4 Topic Messaging with Filtered Subscriptions
Topic:
```
inference-results
```

Subscriptions:
- notifications (all messages)  
- high-priority (priority = high)  

```python
def topic_messaging():
    """Send messages to a topic and receive from filtered subscriptions."""
    # ...
```

---

# 4. Configure Python Environment
cd client
python -m venv .venv

Bash:
```bash
source .venv/bin/activate
# Windows:
source .venv/Scripts/activate
```

PowerShell:
```powershell
.\.venv\Scripts\Activate.ps1
```

pip install -r requirements.txt

# 5. Run the App
```bash
python app.py
```

Open:
```
http://localhost
```

Use UI buttons:
- Send Messages  
- Process Messages  
- Inspect Dead-Letter Queue  
- Send & Receive Topic Messages  

---

# 6. Clean Up Resources
```bash
az group delete --name <rg-name> --no-wait --yes
```

⚠️ Deletes all resources in the group.

---

# 7. Troubleshooting

### Namespace
- Provisioning state = Succeeded  
- Tier = Standard  

### Messaging Entities
- Queue  
- Topic  
- Subscriptions  
- SQL filter  

### Code
- All blocks added in correct sections  
- Indentation consistent  

### Environment Variables
- `.env` contains FQDN  
- Variables loaded  

### Authentication
```bash
az account show
```

### Python Environment
```bash
pip list
```

---

© Microsoft Learn

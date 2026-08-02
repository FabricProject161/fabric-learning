# Exercise 08: CI/CD with Microsoft Fabric

## Objective

Learn how to implement Continuous Integration and Continuous Deployment (CI/CD) practices for Microsoft Fabric projects using GitHub and deployment pipelines.

## Prerequisites

- Completed Exercise 07: Git Integration
- Microsoft Fabric workspace connected to GitHub
- GitHub repository containing Fabric artifacts
- Access to at least two Fabric workspaces:
  - Development
  - Test (or Production)

## Scenario

Your organization wants to automate the promotion of Fabric artifacts from a development environment to a test environment. Your goal is to establish a basic CI/CD workflow that supports controlled deployments and version tracking.

## Tasks

### Task 1: Create Environment Workspaces

Create two Fabric workspaces:

```text
Fabric-Dev
```

```text
Fabric-Test
```

Document the purpose of each workspace.

| Workspace | Purpose |
|------------|-----------|
| Fabric-Dev | Development and testing |
| Fabric-Test | Validation and acceptance testing |

---

### Task 2: Verify Git Connection

Confirm that your Development workspace is connected to GitHub.

Verify that the repository contains:

- Lakehouse artifacts
- Notebooks
- Pipelines
- Other Fabric items

Take a screenshot of the repository structure.

---

### Task 3: Create a Feature Branch

Create a branch:

```text
feature/cicd-demo
```

Make a small change to a notebook.

Example:

```python
print("CI/CD Demo")
```

Commit the change.

Commit message:

```text
Added CI/CD demonstration notebook update
```

---

### Task 4: Create a Pull Request

Create a Pull Request from:

```text
feature/cicd-demo
```

to

```text
main
```

Review the changes and merge the Pull Request.

Verify that the commit appears in the main branch.

---

### Task 5: Configure Deployment Pipeline

Create a Fabric Deployment Pipeline.

Pipeline stages:

```text
Development → Test
```

Assign:

| Stage | Workspace |
|---------|------------|
| Development | Fabric-Dev |
| Test | Fabric-Test |

---

### Task 6: Deploy Content

Deploy the notebook changes from:

```text
Fabric-Dev
```

to

```text
Fabric-Test
```

Verify that the updated notebook appears in the target workspace.

---

### Task 7: Validate Deployment

Open the deployed notebook and confirm:

- Notebook exists
- Latest changes are visible
- Execution succeeds

Document the validation results.

---

### Task 8: Deployment Review

Identify the following:

- What was deployed?
- What was not deployed?
- What deployment challenges were encountered?

Document your findings.

---

## Deliverables

- Screenshot of Git repository
- Screenshot of Pull Request
- Screenshot of Deployment Pipeline
- Screenshot of successful deployment
- Screenshot

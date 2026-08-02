# Exercise 07: Git Integration

## Objective

Learn how to integrate Microsoft Fabric with GitHub to enable version control, collaboration, and CI/CD practices.

## Prerequisites

- Microsoft Fabric workspace
- GitHub account
- GitHub repository (for example: `fabric-learning`)
- Workspace Admin permissions in Fabric

## Scenario

You are developing analytics solutions in Microsoft Fabric and want to track changes using Git. Your goal is to connect a Fabric workspace to a GitHub repository and synchronize Fabric artifacts with source control.

## Tasks

### Task 1: Create a GitHub Repository

Create a repository named:

```text
fabric-learning
```

Ensure the repository contains:

- README.md
- MIT License
- Python .gitignore

---

### Task 2: Connect Fabric Workspace to GitHub

In Microsoft Fabric:

1. Open your workspace.
2. Navigate to **Workspace Settings**.
3. Select **Git Integration**.
4. Choose **GitHub** as the provider.
5. Connect to your repository.

Verify that the workspace is successfully connected.

---

### Task 3: Commit Workspace Items

Create the following Fabric items:

- Lakehouse
- Notebook
- Data Pipeline

Commit all changes to Git.

Commit message:

```text
Initial Fabric artifacts
```

---

### Task 4: Review Repository Structure

Review the generated files in GitHub.

Identify:

- Notebook definitions
- Pipeline definitions
- Lakehouse metadata

Document your observations.

---

### Task 5: Create a Feature Branch

Create a new branch:

```text
feature/notebook-enhancements
```

Switch the Fabric workspace to that branch.

---

### Task 6: Modify a Notebook

Add a new cell to an existing notebook:

```python
print("Hello Fabric Git Integration")
```

Commit the changes.

Commit message:

```text
Added notebook enhancement
```

---

### Task 7: Compare Changes

In GitHub:

1. Open the branch.
2. Review the commit history.
3. Compare changes between:
   - `main`
   - `feature/notebook-enhancements`

Document what changed.

---

### Task 8: Merge Changes

Create a Pull Request.

Merge:

```text
feature/notebook-enhancements
```

into

```text
main
```

Verify that the changes appear in the main branch.

---

## Deliverables

- Screenshot of Git Integration settings
- Screenshot of GitHub repository
- Screenshot of commit history
- Screenshot of Pull Request
- Screenshot of successful merge

---

## Success Criteria

- Fabric workspace connected to GitHub
- Artifacts committed successfully
- Feature branch created
- Pull Request completed
- Changes merged into main

---

## Challenge

Complete the following additional tasks:

- Create a second feature branch
- Modify a pipeline
- Commit the changes
- Create and merge another Pull Request

---

## Reflection Questions

1. What benefits does Git provide for Fabric development?
2. What Fabric artifacts can be version controlled?
3. How do branches support collaborative development?
4. What challenges might occur during merges?
5. How could Git Integration support CI/CD processes?

---

## Learning Notes

### Key Learnings

-
-
-

### Challenges Encountered

-
-
-

### Next Steps

-
-
-

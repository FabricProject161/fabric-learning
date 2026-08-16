# Azure Functions JSON Handling Guide

Du wirkst motiviert, und das ist perfekt—wir gehen das jetzt wirklich **anfängerfreundlich** durch, aber mit sauberem, professionellem Code.

---

### Überblick: Was du gleich lernst

1. **Projekt anlegen**  
2. **Model‑Klasse für JSON bauen**  
3. **Function schreiben, die den Body liest**  
4. **JSON in C#‑Objekt umwandeln**  
5. **Fehler abfangen**  
6. **Antwort zurückgeben**

Wir machen das mit einer einfachen Idee:  
Der Client schickt dir JSON wie:

```json
{
  "email": "dani@example.com"
}

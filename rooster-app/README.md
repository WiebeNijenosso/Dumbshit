# Lesrooster

Een eenvoudige rooster-app voor leerlingen. Open `index.html` in je browser; je hoeft niets te installeren.

## Pagina's
- **Rooster** (`index.html`): lesdagen toevoegen en verwijderen, en leerlingen per kwartier inplannen (15–120 minuten).
  Met "Vaste leerlingen overnemen" worden leerlingen automatisch ingepland op dezelfde tijd als:
  - een week eerder (type *elke week*, en *lespakket* zolang er lessen over zijn)
  - twee weken eerder (type *elke twee weken*)
- **Leerlingen** (`leerlingen.html`): leerlingen toevoegen, bewerken en verwijderen, met naam, telefoonnummer, type
  (elke week / elke twee weken / lespakket van x lessen) en een presentiegetal dat je zelf aanpast met − / +.

Alles wordt opgeslagen in de browser (localStorage). Via "Back-up downloaden" op de leerlingenpagina bewaar je een JSON-bestand dat je later weer kunt terugzetten.

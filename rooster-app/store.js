// Gedeelde opslag voor beide pagina's (localStorage in de browser).
const STORAGE_KEY = "rooster-app-v1";

const TYPES = {
  weekly: "Elke week",
  biweekly: "Elke twee weken",
  package: "Lespakket",
};

function emptyData() {
  return { students: [], days: [], lessons: [] };
}

function loadData() {
  try {
    const raw = localStorage.getItem(STORAGE_KEY);
    if (!raw) return emptyData();
    const data = JSON.parse(raw);
    return {
      students: Array.isArray(data.students) ? data.students : [],
      days: Array.isArray(data.days) ? data.days : [],
      lessons: Array.isArray(data.lessons) ? data.lessons : [],
    };
  } catch (e) {
    console.error("Kon gegevens niet laden", e);
    return emptyData();
  }
}

function saveData(data) {
  try {
    localStorage.setItem(STORAGE_KEY, JSON.stringify(data));
  } catch (e) {
    alert("Opslaan mislukt: " + e.message);
  }
}

function uid() {
  return Date.now().toString(36) + Math.random().toString(36).slice(2, 8);
}

function escapeHtml(str) {
  return String(str ?? "").replace(/[&<>"']/g, (c) => ({
    "&": "&amp;", "<": "&lt;", ">": "&gt;", '"': "&quot;", "'": "&#39;",
  })[c]);
}

function timeToMin(t) {
  const [h, m] = t.split(":").map(Number);
  return h * 60 + m;
}

function minToTime(min) {
  const h = Math.floor(min / 60);
  const m = min % 60;
  return String(h).padStart(2, "0") + ":" + String(m).padStart(2, "0");
}

function typeLabel(student) {
  if (student.type === "package") return `Lespakket (${student.packageSize} lessen)`;
  return TYPES[student.type] || student.type;
}

function formatDate(iso) {
  const d = new Date(iso + "T00:00:00");
  return d.toLocaleDateString("nl-NL", { weekday: "long", day: "numeric", month: "long", year: "numeric" });
}

function formatDateShort(iso) {
  const d = new Date(iso + "T00:00:00");
  return d.toLocaleDateString("nl-NL", { weekday: "short", day: "numeric", month: "short" });
}

// Back-up: exporteren/importeren als JSON-bestand
function exportData() {
  const blob = new Blob([JSON.stringify(loadData(), null, 2)], { type: "application/json" });
  const a = document.createElement("a");
  a.href = URL.createObjectURL(blob);
  a.download = `rooster-backup-${new Date().toISOString().slice(0, 10)}.json`;
  a.click();
  URL.revokeObjectURL(a.href);
}

function importData(file, onDone) {
  const reader = new FileReader();
  reader.onload = () => {
    try {
      const data = JSON.parse(reader.result);
      if (!data || !Array.isArray(data.students) || !Array.isArray(data.days) || !Array.isArray(data.lessons)) {
        throw new Error("Ongeldig back-upbestand");
      }
      if (!confirm("Alle huidige gegevens vervangen door deze back-up?")) return;
      saveData(data);
      onDone && onDone();
    } catch (e) {
      alert("Importeren mislukt: " + e.message);
    }
  };
  reader.readAsText(file);
}

function setupBackupButtons(onImport) {
  const exp = document.getElementById("export-btn");
  const imp = document.getElementById("import-input");
  if (exp) exp.addEventListener("click", exportData);
  if (imp) imp.addEventListener("change", () => {
    if (imp.files[0]) importData(imp.files[0], onImport);
    imp.value = "";
  });
}

function todayIso() {
  const d = new Date();
  return `${d.getFullYear()}-${String(d.getMonth() + 1).padStart(2, "0")}-${String(d.getDate()).padStart(2, "0")}`;
}

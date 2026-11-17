# Lesrooster – Android-app

Deze map verpakt de web-app uit `../rooster-app` als Android-app met [Capacitor](https://capacitorjs.com).

## Downloaden
Bij elke wijziging bouwt GitHub Actions automatisch een nieuwe APK. Download `Lesrooster.apk` via
**Releases → Lesrooster Android-app** in deze repository en open het bestand op je telefoon.
Android vraagt de eerste keer om toestemming om apps "van onbekende bronnen" te installeren.

Nieuwe versies installeer je gewoon over de oude heen; je leerlingen en rooster blijven bewaard.
Verwijder je de app, dan zijn de gegevens weg: maak dus af en toe een back-up (Leerlingen → Back-up downloaden).

## Zelf bouwen
Nodig: Node 22, JDK 21 en de Android SDK.

```sh
npm ci
npx cap sync android
cd android && ./gradlew assembleRelease
```

De APK staat daarna in `android/app/build/outputs/apk/release/`.

De sleutel `android/app/lesrooster.keystore` (wachtwoord `lesrooster`) staat bewust in de repo, zodat
elke build dezelfde handtekening heeft. Dat is prima voor eigen gebruik; voor de Play Store gebruik je een eigen geheime sleutel.

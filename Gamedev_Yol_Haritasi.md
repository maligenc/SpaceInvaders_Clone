# Gamedev Yol Haritası — İş Analistinden Oyun Geliştiriciye

> **Hedef:** ~8 ayda, yayınlanmış oyunlar ve belgelenmiş bir süreçten oluşan bir portföyle
> Unity gameplay developer pozisyonlarına başvurabilir hale gelmek.
> **Tempo:** Haftada 3-5 saat (2 seans). Süreler tavsiyedir; sıkışınca takvim kayar, kapsam kaymaz.

---

## Mevcut Envanter (başlangıç noktası)

| Varlık | Durum | Nerede işe yarayacak |
|---|---|---|
| C# | .NET backend ortamında edinilmiş, iyi seviye | Unity'nin ana dili — en büyük teknik avantaj |
| İş analistliği | Aktif meslek | Kapsam yönetimi, GDD yazımı, kabul kriterleri — bitiremeyen %90'dan ayrıştıran beceri |
| Blender | 20 saatlik eğitim + 1 render (paslanmış) | Faz 3'te low-poly asset üretimi |
| Art of Game Design | %30 okundu | Faz 2 tasarım kararlarında "lens" kullanımı; okumaya devam |

**Strateji:** Motor = Unity (C# + iş ilanları + İstanbul mobil oyun ekosistemi).
İlk projeler 2D (haftalık süre kısıtında *biten* iş), 3D sonradan gelir.

---

## FAZ 1 — Isınma: Space Invaders Klonu (1.-2. ay)

**Amaç:** Unity'yi öğrenirken "bitirip yayınlama" refleksini ilk günden kazanmak.
Portföyde yarım proje sıfır projedir; bu fazın çıktısı güzel oyun değil, **yayınlanmış** oyundur.

- Tek mekanik, tek ekran: Space Invaders klonu
- Kapsam MoSCoW ile kilitli, haftalık görevler ayrı dokümanda → `SpaceInvaders_Proje_Plani.md`
- WebGL build → itch.io'da yayın
- 8 haftalık yazı ile devlog başlangıcı

**Faz bitti kriteri:**
- [ ] Oyun itch.io'da herkese açık ve tarayıcıda çalışıyor
- [ ] Tüm Must Have maddeleri kapandı
- [ ] Devlog'da 8+ yazı var
- [ ] LinkedIn'de duyuruldu

**Kazanımlar:** Unity temelleri (prefab, collider, UI, build pipeline), git ile Unity proje yönetimi, kapsam disiplini.

---

## FAZ 2 — Asıl Portföy Oyunu (3.-5. ay)

**Amaç:** Klon değil, **kendi tasarımın**. İşverene "ben sadece kod yazmam, ürün düşünürüm"
diyen proje. İş analisti kimliğinin sahneye çıktığı faz.

### Adımlar
1. **Beyin fırtınası + konsept seçimi (Hafta 1):** Tek güçlü mekaniğe kurulu, 2D, küçük bir oyun.
   Seçim kriteri: "Bu mekanik 30 saniyelik GIF'te kendini anlatabiliyor mu?"
2. **GDD (Hafta 1-2):** 2 sayfalık game design document. Core loop, mekanik tanımı,
   kazanma/kaybetme koşulları, kapsam sınırları. MoSCoW yine burada.
3. **Art of Game Design entegrasyonu:** Kitabı bitir; her büyük tasarım kararında en az bir
   "lens" uygula ve devlog'da hangi lensi neden kullandığını yaz. (Portföyde altın değerinde içerik.)
4. **Geliştirme (Hafta 3-10):** Faz 1 disiplinin aynısı — seans hedefleri, haftalık devlog,
   listede olmayan özellik eklenmez.
5. **Playtest döngüsü (Hafta 8+):** En az 3 kişiye oynat, geri bildirimi GDD'ye işle, revize et.
   (İş analisti dilinde: kullanıcı kabul testi.)
6. **Yayın (Hafta 11-12):** itch.io + tanıtım GIF'i + kapsamlı kapanış devlog yazısı.

**Faz bitti kriteri:**
- [ ] Özgün oyun itch.io'da yayında
- [ ] 2 sayfalık GDD repo'da herkese açık
- [ ] En az 3 playtest yapıldı ve en az 3 geri bildirim işlendi
- [ ] Art of Game Design bitirildi, en az 3 lens uygulaması devlog'da belgelendi

**Kazanımlar:** Oyun tasarımı pratiği, GDD yazımı, playtest yönetimi, "ürün düşünen geliştirici" kanıtı.

---

## FAZ 3 — 3D Dokunuşu: Blender + Unity Pipeline (6.-8. ay)

**Amaç:** 3D pipeline'ı (modelleme → export → Unity'de materyal/ışık) uçtan uca **bir kez**
yaşamış olmak. Hedef 3D uzmanı olmak değil; "3D'ye yabancı değilim" diyebilmek.

### Adımlar
1. **Blender tazeleme (Hafta 1-2):** 20 saatlik eğitimin üzerinden zaman geçti; kısa bir
   low-poly tutorial ile eli ısıt (donut'a geri dönme, doğrudan low-poly prop modelleme).
2. **Asset üretimi (Hafta 3-5):** Kendi projen için 5-10 low-poly asset (duvar, kapı, eşya vb.).
   Ders: FBX export, ölçek, pivot, basit UV/materyal.
3. **Prototip (Hafta 6-10):** Kendi asset'lerinle küçük bir 3D sahne — kısa bir yürüme
   simülasyonu VEYA tek odalı bir puzzle. Kapsam: tek sahne, 5-10 dakikalık deneyim.
4. **Yayın (Hafta 11-12):** itch.io + devlog. "Blender'dan Unity'ye kendi asset pipeline'ım"
   yazısı — bu yazı teknik blog içeriği olarak da değerli.

**Faz bitti kriteri:**
- [ ] Tüm görsel asset'leri kendi üretimi olan 3D prototip yayında
- [ ] Pipeline devlog yazısı yayınlandı

**Kazanımlar:** 3D iş akışı, Blender-Unity entegrasyonu, portföyde çeşitlilik.

---

## SÜREKLİ KATMAN — Devlog (Hafta 0'dan itibaren, hiç durmaz)

**Ne:** Başkasına öğreten site değil, kendi yolculuğunu belgeleyen devlog.
**Nerede:** GitHub Pages (`maligenc.github.io`, Jekyll). Site tasarımıyla uğraşmak yasak.
**Ritim:** Her hafta, seansın son 20 dakikası. "Sonra yazarım" dediğin yazı yazılmaz.

**Yazı şablonu:** Bu hafta ne yaptım (+ görsel/GIF şart) → Ne ters gitti (asıl değerli kısım)
→ Ne öğrendim → Gelecek hafta (tek cümle, kendine söz).

**Neden kritik:** Junior pozisyonda teknik beceriden çok "bu insan disiplinli, bitiriyor ve
iletişimi güçlü" sinyali fark yaratır. Devlog bu sinyalin kendisidir; ayrıca GitHub profili
canlı kalır.

---

## SÜREKLİ KATMAN — Kariyer Hazırlığı (Faz 2 ortasından itibaren)

- **Ay 4:** LinkedIn başlığına "aspiring game developer" tarzı sinyal; oyun/devlog paylaşımları düzenli.
- **Ay 5-6:** İstanbul ekosistemini haritala (mobil stüdyolar ağırlıklı: Peak, Dream, Spyke
  tarzı büyükler + bol miktarda küçük/orta stüdyo). Global remote junior ilanlarını da izle.
  İlanlardaki ortak gereksinimleri not et → Faz 3'te eksik kapatma listesi olarak kullan.
- **Ay 6+:** CV'yi "iş analisti + yayınlanmış 3 oyun + devlog" hikâyesiyle yeniden yaz.
  Konum: "domain bilgisi + ürün düşüncesi olan junior gameplay developer".
- **Ay 7-8:** Başvurulara başla. Her başvuruda portföy linki + en güçlü devlog yazısı.
  Paralel: Unity mülakat konularına çalış (temel veri yapıları, Unity yaşam döngüsü,
  basit oyun mekaniği soruları).

**Not:** İş bulmak Faz 3'ün bitmesini beklemez; Faz 2 yayınlandığı anda başvuru yapılabilir
durumdasın. Faz 3 süreci güçlendirir, kapı açıldığında ertelenebilir.

---

## Oyun Kuralları (tüm fazlar için geçerli)

1. **Yayınlanmamış oyun portföyde yoktur.** Her faz itch.io'da biter.
2. **Kapsam dokümanı donduktan sonra yeni özellik eklenmez.** Fikirler "sonraki faz not defteri"ne.
3. **Bir hafta bitmezse sıkıştırılmaz, takvim kayar.** 8 ay 10 ay olabilir; yarım faz olamaz.
4. **Her seans tek cümlelik hedefle başlar.** Hedefsiz seans = tutorial cehennemi.
5. **Asset üretiminde zaman tuzağına düşme:** 2D fazlarında hazır paket (Kenney vb.) kullanılır,
   kendi asset'i yalnızca Faz 3'te üretilir.
6. **Makine değiştirmeden önce push, oturmadan önce pull.** Aynı sahne iki makinede aynı anda açılmaz.
7. **Devlog atlanmaz.** Kod yazılmayan hafta bile "bu hafta neden ilerleyemedim" yazısı yazılır.

---

## Kilometre Taşları — Özet

| Zaman | Çıktı |
|---|---|
| Ay 2 sonu | 🚀 Space Invaders klonu itch.io'da |
| Ay 5 sonu | 🚀 Özgün 2D oyun + GDD yayında |
| Ay 6 | 📋 CV/LinkedIn yenilendi, ekosistem haritası hazır |
| Ay 8 sonu | 🚀 3D prototip yayında + başvurular aktif |
| Sürekli | ✍️ Haftalık devlog, kesintisiz |

---

*Bağlantılı doküman: `SpaceInvaders_Proje_Plani.md` (Faz 1 detay planı)*
*Son güncelleme: 4 Temmuz 2026*

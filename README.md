# Unity短片辭典 範例專案

[Unity短片辭典](https://hkhorazon.github.io/UnityDictionary/) 影片中示範的場景。一支影片對應一個場景，打開 `Assets/Scenes/` 裡同編號的場景就能跟著影片操作。

## 開啟方式

1. 安裝 Unity Hub 和 **Unity 6000.3.25f1**（其他 Unity 6 版本通常也能開，但會跳出升級提示）
2. 按右上角綠色的 **Code > Download ZIP** 下載後解壓縮，或用 git clone
3. Unity Hub 按 **Add**，選這個資料夾（打開看得到 `Assets` 的那一層）
4. 第一次開啟要匯入比較久，請耐心等候

> 專案路徑請避免中文、桌面和雲端同步資料夾。

## 場景對照表

| 影片 | 場景 | 裡面有什麼 |
|------|------|------------|
| [BA04 Unity六大基本介面](https://www.youtube.com/watch?v=QC9_tpwVHec) | `BA04_Interface` | 幾個基本物件，認識 Hierarchy、Inspector 等視窗 |
| [BA05 Scene 場景視窗](https://www.youtube.com/watch?v=z4gBflIv_a0) | `BA05_SceneView` | 物件散得很開，練習縮放、旋轉視角；`Tiny`、`FarAway` 要在 Hierarchy 雙擊才找得到 |
| [BA06 Transform 移動旋轉縮放](https://www.youtube.com/watch?v=5m3G0TcmoJA) | `BA06_Transform` | 位置、旋轉、縮放各一個；`Cube_ScaleZero` 縮放打 0 變扁 |
| [BA07 匯入素材](https://www.youtube.com/watch?v=W9E9sptwUqA) | `BA07_ImportAsset` | `Art/Textures` 裡兩張圖：`Icon` 是 Sprite（透明背景），`Checker` 當材質貼圖 |
| [BA09 Material 材質球](https://www.youtube.com/watch?v=0uuTZh1GfCM) | `BA09_Material` | 三個方塊共用 `Mat_Red`，改一個全部跟著變 |
| [BA10 燈光與天空](https://www.youtube.com/watch?v=sHITZbvKwak) | `BA10_Lighting` | Directional、Point、Spot 三種燈 |
| [BA11 相機與 Game 視窗](https://www.youtube.com/watch?v=5t53MULl6_w) | `BA11_Camera` | `OrthoCamera` 是正交相機（預設關閉）；`TooClose` 太靠近相機，Game 視窗看不到 |
| [BA12 第一支腳本](https://www.youtube.com/watch?v=VwftDRA9zmM) | `BA12_FirstScript` | 同一支 `Rotator.cs` 掛在兩個方塊上，速度不同 |
| [BA13 Prefab 預製物件](https://www.youtube.com/watch?v=FBi6cWCDEjw) | `BA13_Prefab` | `Prefabs/Tree` 放了三棵，最右邊那棵改過縮放（Override） |
| [BA14 父子關係](https://www.youtube.com/watch?v=CitNjdxbnbI) | `BA14_Parent` | 空物件 `Sword` 放在劍柄，按 Play 會以劍柄為中心旋轉 |
| [BA15 UI Canvas 與按鈕](https://www.youtube.com/watch?v=18WwKB7d5Hs) | `BA15_UI` | 標題列用 Anchor 貼齊上方；按鈕的 On Click 呼叫 `ClickCounter.OnClick` |
| [BA16 3D 物理：Rigidbody 與 Collider](https://www.youtube.com/watch?v=m5loa9RpEZ4) | `BA16_Physics` | 球滾下斜坡被隱形牆擋住；配 Box Collider 的球滾不動；沒有 Collider 的方塊掉穿地板 |
| [BA17 3D 物理：Trigger 觸發器](https://www.youtube.com/watch?v=PDB6kFV6t9o) | `BA17_Trigger` | 球掉進 `TriggerZone` 後，`Respawn.cs` 把它移回上方重新掉落 |
| [BA18 TMP 中文字型](https://www.youtube.com/watch?v=Rvdl7QHNumc) | `BA18_TMPFont` | `Fonts/NotoSansTC SDF`（Dynamic），並加進 LiberationSans SDF 的 Fallback |
| [BA20 場景與存檔](https://www.youtube.com/watch?v=NyUcp8fHNCo) | `BA20_SceneA`、`BA20_SceneB` | 兩個場景，在 Project 雙擊切換 |

BA01–BA03、BA08、BA19 是 Unity Hub、安裝、套件、打包的操作，沒有對應場景。

## 資料夾

| 資料夾 | 內容 |
|--------|------|
| `Scenes` | 各影片的場景 |
| `Scripts` | `Rotator`（BA12、BA14）、`ClickCounter`（BA15）、`Respawn`（BA17） |
| `Materials` | 材質球 |
| `Prefabs` | Tree |
| `Art/Textures` | Icon、Checker 兩張圖 |
| `Fonts` | Noto Sans TC 字型與 TMP Font Asset |

## 授權

字型 Noto Sans TC 採用 SIL Open Font License 1.1，見 `Assets/Fonts/OFL.txt`。

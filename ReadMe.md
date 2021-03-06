﻿# 有52張牌，用一個陣列用正敘排序存放，請隨機洗牌後發牌成4等分
## 使用TDD來開發，可以讓程式更精簡，面對未來需求的改變也更靈活。下列是針對這次題目提煉出的測試案例。
* TestCase
    * 總共4份
    * 每1份13張牌
    * 每1份牌都沒有重複
    * 4份牌都不相同
    * 重複呼叫結果不同
    * 牌的數字在1-52之間
    * 沒有重複的牌
### TDD的原則是"一次只做一件事"  
在git的commit中，可以清楚的看到測試是如何產生production code。
### 當測試為紅燈  
* 因為 production code尚未支援新的 scenario ，所以測試結果為紅燈。  
* 可以讓開發者清楚的知道目標就是要通過這個紅燈。  
### 當測試變成綠燈  
* production code 在這個新的 scenario 底下可以如同預期般地運作。  
* production code 之前支援的所有 scenarios 也都如預期正常運作。
    
## 過程中有談到想看Sort，但是Sort的實作多種。再定義清楚之前，我先用暴力法提供簡單的解法。
* 有測試的保護下，我可以輕易地重構Poker類別，再新增排序的功能。
* 將排序演算法實作在擴充方法中
* 未來修改排序演算法，只需要專注在Helper類別上，更不容易傷害到原本的邏輯。

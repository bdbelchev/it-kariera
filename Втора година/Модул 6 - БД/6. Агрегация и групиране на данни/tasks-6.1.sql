-- 1
USE gringotts;

SELECT 
    COUNT(*) Count
FROM
    wizzard_deposits;
    
-- 2
SELECT 
    MAX(magic_wand_size) longest_magic_wand
FROM
    wizzard_deposits;
﻿
SELECT F.NAME FROM FAMILIES F
INNER JOIN BILLS B ON B.ID = F.BILL_ID
WHERE B.AMOUNT = (SELECT MAX(AMOUNT) FROM BILLS)

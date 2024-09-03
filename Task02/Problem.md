** Problem Statement **
---

Give X, Y coordinate array find the co-ordinates of the triangle which don't have any point inside it.

Approach:
1. Sort points on the x axis
2. Find id of tringle using "xy-xy-xy" as key
3. For each point p1.x <= t.x <= p3.x 
   1. if t is in cone p1-p2 and p1-p3 and is on right side p2-p3 then conditions are mate.
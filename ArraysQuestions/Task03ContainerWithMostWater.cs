﻿using System;

namespace ArraysQuestions
{
    /* Container With Most Water
     * 
     * Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). 
     * n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). 
     * Find two lines, which together with x-axis forms a container, such that the container contains the most water. 
     * Note: You may not slant the container and n is at least 2.
     */
    public class Task03ContainerWithMostWater
    {
        public static int Do(int[] height)
        {
            int maxarea = 0, left = 0, right = height.Length - 1;

            while (left < right)
            {
                maxarea = Math.Max(
                    maxarea, 
                    Math.Min(height[left], height[right]) * (right - left)
                );

                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return maxarea;
        }
    }
}

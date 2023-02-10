using DatenstrukturenSingleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class Factorypattern
    {
        public SortStrategy Sortstartegyfactory(String strategie)
        {
            switch (strategie)
            {
                case "insertionSort":
                    return new InsertionSort();
                case "quickSort":
                    return new Quicksort();
                case "bubbleSort":
                    return new BubbleSort();
                case "selectionSort":
                    return new SelectionSort();
            }
            return null;
        }
    }
}
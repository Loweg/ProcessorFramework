﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using RimWorld;
using Verse;

namespace ProcessorFramework
{
    /*public class Command_Process : Command_Action
    {
        public ProcessDef processToTarget;
        public List<ProcessDef> processOptions = new List<ProcessDef>();

        public override IEnumerable<FloatMenuOption> RightClickFloatMenuOptions
        {
            get
            {
                List<FloatMenuOption> floatMenuOptions = new List<FloatMenuOption>();
                foreach (ProcessDef process in processOptions)
                {
                    floatMenuOptions.Add(
                        new FloatMenuOption(
                            process.customLabel != "" ? process.customLabel : process.thingDef.label.CapitalizeFirst(),
                            () => ChangeProcess(processToTarget, process),
                            ProcessorFramework_Utility.GetIcon(process.thingDef, PF_Settings.singleItemIcon),
                            Color.white,
                            MenuOptionPriority.Default,
                            null,
                            null,
                            0f,
                            null,
                            null
                        )
                    );
                }
                if (PF_Settings.sortAlphabetically)
                {
                    floatMenuOptions.SortBy(fmo => fmo.Label);
                }
                return floatMenuOptions;
            }
        }

        internal static void ChangeProcess(ProcessDef processToTarget, ProcessDef process)
        {
            foreach (Thing thing in Find.Selector.SelectedObjects.OfType<Thing>()) {
                CompProcessor comp = thing.TryGetComp<CompProcessor>();
                if (comp != null && comp.CurrentProcess == processToTarget) {
                    comp.CurrentProcess = process;
                }
            }
        }
    }*/
}

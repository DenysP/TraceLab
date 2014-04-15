﻿// TraceLab - Software Traceability Instrument to Facilitate and Empower Traceability Research
// Copyright (C) 2012-2013 CoEST - National Science Foundation MRI-R2 Grant # CNS: 0959924
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see<http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TraceLab.Core.ExperimentExecution;
using TraceLab.Core.Experiments;

namespace TraceLab.Core.Test.ExperimentExecution
{
    public class ExperimentRunnerHelper
    {
        internal static IExperimentRunner CreateExperimentRunner(IExperiment currentExperiment,
                TraceLab.Core.Workspaces.Workspace workspace,
                TraceLab.Core.Components.ComponentsLibrary library)
        {
            // Allow all nodes to send info to logs - if any targets exist.
            foreach (TraceLab.Core.Experiments.ExperimentNode node in currentExperiment.Vertices)
            {
                var componentNode = node as TraceLab.Core.Experiments.ComponentNode;
                if (componentNode != null)
                {
                    foreach (TraceLab.Core.Settings.LogLevelItem item in componentNode.Data.Metadata.LogLevels)
                    {
                        item.IsEnabled = true;
                    }
                }
            }

            RunnableNodeFactory templateGraphNodesFactory = new RunnableNodeFactory(workspace);
            TraceLab.Core.ExperimentExecution.RunnableExperimentBase template = GraphAdapter.Adapt(currentExperiment, templateGraphNodesFactory, library, workspace.TypeDirectories);

            var dispatcher = ExperimentRunnerFactory.CreateExperimentRunner(template);
            return dispatcher;
        }
    }
}
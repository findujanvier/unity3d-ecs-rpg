﻿using Entitas;
using Entitas.CodeGenerator;

[Core, SingleEntity]
public class TickComponent : IComponent {
	public long currentTick;
}

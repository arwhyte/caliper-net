﻿using System.Collections.Generic;

using Newtonsoft.Json;
using NodaTime;

namespace ImsGlobal.Caliper.Entities.Agent {
	using ImsGlobal.Caliper.Entities.Foaf;

	public class Agent : Entity, IAgent {

		public Agent( string id )
			:base (id) {
            this.Type = EntityType.Agent;
		}

	}

}

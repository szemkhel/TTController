﻿using System;
using System.Collections.Generic;
using TTController.Common;

namespace TTController.Service.Manager
{
    public class EffectManager : IDisposable
    {
        private readonly Dictionary<Guid, List<IEffectBase>> _effectsGuidMap;

        public EffectManager()
        {
            _effectsGuidMap = new Dictionary<Guid, List<IEffectBase>>();
        }

        public void Add(Guid guid, IEffectBase effect)
        {
            if(!_effectsGuidMap.ContainsKey(guid))
                _effectsGuidMap.Add(guid, new List<IEffectBase>());
            _effectsGuidMap[guid].Add(effect);
        }

        public IReadOnlyList<IEffectBase> GetEffects(Guid guid)
        {
            if (!_effectsGuidMap.ContainsKey(guid))
                return null;

            return _effectsGuidMap[guid].AsReadOnly();
        }

        public void Dispose()
        {
            foreach (var effects in _effectsGuidMap.Values)
                foreach (var effect in effects)
                    effect.Dispose();
        }
    }
}

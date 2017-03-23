// automatically generated by the FlatBuffers compiler, do not modify

namespace InWorldz.Arbiter.Serialization
{

using System;
using FlatBuffers;

public struct HalcyonGroup : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static HalcyonGroup GetRootAsHalcyonGroup(ByteBuffer _bb) { return GetRootAsHalcyonGroup(_bb, new HalcyonGroup()); }
  public static HalcyonGroup GetRootAsHalcyonGroup(ByteBuffer _bb, HalcyonGroup obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public HalcyonGroup __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public InWorldz.Arbiter.Serialization.HalcyonPrimitive? Root { get { int o = __p.__offset(4); return o != 0 ? (InWorldz.Arbiter.Serialization.HalcyonPrimitive?)(new InWorldz.Arbiter.Serialization.HalcyonPrimitive()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public InWorldz.Arbiter.Serialization.HalcyonPrimitive? ChildParts(int j) { int o = __p.__offset(6); return o != 0 ? (InWorldz.Arbiter.Serialization.HalcyonPrimitive?)(new InWorldz.Arbiter.Serialization.HalcyonPrimitive()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ChildPartsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public InWorldz.Arbiter.Serialization.HalcyonPrimitiveBaseShape? Shape { get { int o = __p.__offset(8); return o != 0 ? (InWorldz.Arbiter.Serialization.HalcyonPrimitiveBaseShape?)(new InWorldz.Arbiter.Serialization.HalcyonPrimitiveBaseShape()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<HalcyonGroup> CreateHalcyonGroup(FlatBufferBuilder builder,
      Offset<InWorldz.Arbiter.Serialization.HalcyonPrimitive> rootOffset = default(Offset<InWorldz.Arbiter.Serialization.HalcyonPrimitive>),
      VectorOffset childPartsOffset = default(VectorOffset),
      Offset<InWorldz.Arbiter.Serialization.HalcyonPrimitiveBaseShape> shapeOffset = default(Offset<InWorldz.Arbiter.Serialization.HalcyonPrimitiveBaseShape>)) {
    builder.StartObject(3);
    HalcyonGroup.AddShape(builder, shapeOffset);
    HalcyonGroup.AddChildParts(builder, childPartsOffset);
    HalcyonGroup.AddRoot(builder, rootOffset);
    return HalcyonGroup.EndHalcyonGroup(builder);
  }

  public static void StartHalcyonGroup(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddRoot(FlatBufferBuilder builder, Offset<InWorldz.Arbiter.Serialization.HalcyonPrimitive> rootOffset) { builder.AddOffset(0, rootOffset.Value, 0); }
  public static void AddChildParts(FlatBufferBuilder builder, VectorOffset childPartsOffset) { builder.AddOffset(1, childPartsOffset.Value, 0); }
  public static VectorOffset CreateChildPartsVector(FlatBufferBuilder builder, Offset<InWorldz.Arbiter.Serialization.HalcyonPrimitive>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartChildPartsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShape(FlatBufferBuilder builder, Offset<InWorldz.Arbiter.Serialization.HalcyonPrimitiveBaseShape> shapeOffset) { builder.AddOffset(2, shapeOffset.Value, 0); }
  public static Offset<HalcyonGroup> EndHalcyonGroup(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<HalcyonGroup>(o);
  }
  public static void FinishHalcyonGroupBuffer(FlatBufferBuilder builder, Offset<HalcyonGroup> offset) { builder.Finish(offset.Value); }
};


}
